using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MercMarcelo.Dados;
using MercMarcelo.Dados.Entidades;
namespace MercMarcelo.UIUsuarios
{
    
    public partial class ucUsuarios : UserControl
    {
        Dados.Tranzacoes tranz;
        Usuarios user;
        Usuario usuarioSelecionado;
        List<Usuario> lista;
        int ind = 0 ,involario = 0;
     
        public ucUsuarios()
        {

            
            
            InitializeComponent();
        }
        void AtualizaGrid(DataGridView grid)
        {
            grid.DataSource = null;

            grid.DataSource = lista;
            grid.Columns["senha"].Visible = false;
        }
        private void ucUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                user = new Usuarios();
                lista = user.SelectToList().ToListUsuario();
                AtualizaGrid(dataGridView1);
                  
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message + "\n" + erro.ToString());
            }
        }
        private Usuario pegaousuario(int i)
        {
            Usuario u = new Usuario();
                 u.Id_Usuario = int.Parse(dataGridView1.Rows[i].Cells[0].Value.ToString());
                 u.Login = dataGridView1.Rows[i].Cells[1].Value.ToString();
                 u.Senha = dataGridView1.Rows[i].Cells[2].Value.ToString();
                 u.Acesso = (NiveisAcesso) Enum.Parse(typeof(NiveisAcesso), dataGridView1.Rows[i].Cells[3].Value.ToString());
            return u;
     
        }
        private void novoUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contexto.Enabled = false;
            gbRegistro.Enabled = true;
            btnInsrir.Enabled = false;
            txtLogin.Focus();
            tranz = Dados.Tranzacoes.Cadastro;
        }

        private void alterarUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            involario = ind;
            Contexto.Enabled = false;
            gbRegistro.Enabled = true;
            btnInsrir.Enabled = false;
            txtLogin.Focus();
            tranz = Dados.Tranzacoes.Modificacao;
            usuarioSelecionado = pegaousuario(involario);
            txtLogin.Text = usuarioSelecionado.Login;
            txtSenha.Text = usuarioSelecionado.Senha;
            cbAcesso.SelectedIndex = (int) usuarioSelecionado.Acesso ;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpar();
        }
        void limpar()
        {
            Contexto.Enabled = true;
            btnInsrir.Enabled = true;
            gbRegistro.Enabled = false;
            txtLogin.Clear();
            txtSenha.Clear();
            cbAcesso.SelectedIndex = -1;
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                ind = e.RowIndex;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (tranz)
            {
                case Dados.Tranzacoes.Cadastro:
                    cadastrar();
                    break;
                case Dados.Tranzacoes.Modificacao:
                    Atualizar(involario);
                    involario = 0;
                    break;
                default:
                    limpar();
                    
                    break;
            }
            AtualizaGrid(dataGridView1);
            limpar();
            tranz = Dados.Tranzacoes.indef;
        }
        void Deletar()
        {
            try
            {
                if (MessageBox.Show("Tem certeza de que deseja excluir este usuário?", "ATENÇÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    usuarioSelecionado = lista[ind];
                    user.Deletar(usuarioSelecionado);
                    lista.RemoveAt(ind);
                    AtualizaGrid(dataGridView1);
                }
            }
            catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        void cadastrar()
        {
            try
            {
                Usuario novo = new Usuario(0, txtLogin.Text, txtSenha.Text, (NiveisAcesso)cbAcesso.SelectedIndex);
                user.ModificarOuAlterar(Dados.Tranzacoes.Cadastro,novo);
                DataTable tbl = user.Select(string.Format("select id_usuario from tbl_usuarios where login = '{0}' and senha = '{1}'",
                    novo.Login, novo.Senha));
                novo.Id_Usuario = int.Parse(tbl.Rows[0][0].ToString());
                lista.Add(novo);
                dataGridView1.Refresh();
                MessageBox.Show("Cadastrado com sucesso");
                
            
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        void Atualizar(int indice)
        {
            try
            {
                
                usuarioSelecionado.Login = txtLogin.Text;
                usuarioSelecionado.Senha = txtSenha.Text;
                usuarioSelecionado.Acesso = (NiveisAcesso)cbAcesso.SelectedIndex;
                user.ModificarOuAlterar(Dados.Tranzacoes.Modificacao, usuarioSelecionado);
                lista[indice] = usuarioSelecionado;
                MessageBox.Show("modificado com sucesso");
                

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void deletarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Deletar();
        }

        

        
    }
}
