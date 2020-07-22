
using System.Windows.Forms;
using MercMarcelo.Dados.Entidades;
using System.Collections.Generic;
using System;
using MercMarcelo.Dados;
using System.Drawing;

namespace MercMarcelo.Produtos
{
    public partial class CadastroProdutocs : UserControl
    {
        Produto prod;
        Tranzacoes tipo;
       
        public CadastroProdutocs()
        {
            tipo = Tranzacoes.Cadastro;
            InitializeComponent();
            txtvenda.Leave += new EventHandler(txtcompra_Leave);
            
            PreencheCombos();
        }
        void PreencheCombos()
        {
            cbCategorias.DataSource = new Categorias().SelectToList("select * from tbl_categorias").ToListCategorias();
            cbCategorias.DisplayMember = "Descricao";
            cbCategorias.ValueMember = "Descricao";
            cbMedida.DataSource = new UndMedidas().SelectToList("select * from tbl_UndMedidas").ToListMedidas();
            cbMedida.DisplayMember = "Medida";
            cbMedida.ValueMember = "Medida";
        }
        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            
            if(e.KeyCode == Keys.Enter)
            {
                try
                {
                    Dados.Entidades.Produtos pro = new Dados.Entidades.Produtos();

                    prod = pro.LerCodigoDeBarras(txtcodbrr.Text, out tipo);
                    if (tipo == Tranzacoes.Modificacao)
                    {
                        
                        carregaControles(prod);
                        

                    }
                    else if(tipo == Tranzacoes.Cadastro)
                    {
                        limpaControles();
                    }
                }catch(Exception erro)
                {
                    MessageBox.Show(erro.Message);
                }
            }
        }

        private void carregaControles( Produto pro)
        {
            txtcodbrr.Text = pro.Codig_Barras;
            txtid.Text = pro.id_produto.ToString();
            txtDescricao.Text = pro.Descricao;
            cbCategorias.Text = pro.Categoria;
            txtMarca.Text = pro.Marca;
            cbMedida.Text = pro.Und_Medida;
            txtcompra.Text = pro.Preco_Compra.ToString("N");
            txtvenda.Text = pro.Preco_Venda.ToString("N");
            txtqtd.Text = pro.Qtd_Entrada.ToString();
            
            
        }
        private void limpaControles()
        {
            //txtcodbrr.Text = "";
            txtid.Text = "";
            txtDescricao.Text = "";
            cbCategorias.SelectedIndex = 0;
            txtMarca.Text ="";
            cbMedida.SelectedIndex = 0;
            txtcompra.Text = "";
            txtvenda.Text = "";
            txtqtd.Text = "";


        }


        private void button1_Click(object sender, EventArgs e)
        {
            Controles.Colecao col = new Controles.Colecao(new Categorias());
            col.ShowDialog();
            cbCategorias.DataSource = new Categorias().SelectToList("select * from tbl_categorias").ToListCategorias();
            cbCategorias.DisplayMember = "Descricao";
            cbCategorias.ValueMember = "Descricao";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controles.Colecao co = new Controles.Colecao(new Dados.Entidades.UndMedidas());
            co.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (prod == null)
                    return;
                prod.id_produto = string.IsNullOrEmpty(txtid.Text) ? 0 : int.Parse(txtid.Text);
                prod.Codig_Barras = txtcodbrr.Text;
                prod.Descricao = txtDescricao.Text;
                prod.Categoria = cbCategorias.Text;
                prod.Marca = txtMarca.Text;
                prod.Und_Medida = cbMedida.Text;
                prod.Preco_Compra = string.IsNullOrEmpty(txtcompra.Text) ? 0 : double.Parse(txtcompra.Text);
                prod.Preco_Venda = string.IsNullOrEmpty(txtvenda.Text) ? 0 : double.Parse(txtvenda.Text);
                prod.Qtd_Entrada = string.IsNullOrEmpty(txtqtd.Text) ? 0 : double.Parse(txtqtd.Text);

                Dados.Entidades.Produtos pro = new Dados.Entidades.Produtos();
                pro.ModificarOuAlterar(tipo, prod);
                int ret;
                if (int.TryParse(pro.Select(string.Format("select id_produto from tbl_produtos where Codig_Barras = '{0}'", prod.Codig_Barras)).Rows[0][0].ToString(), out ret))
                {
                    prod.id_produto = ret;
                    txtid.Text = "" + prod.id_produto;
                }
            
                if (tipo == Tranzacoes.Cadastro)
                {
                    Estoque est = new Estoque(prod);
                    est.Movimentar(0, prod.Qtd_Entrada, Movimentacao.Entrada);
                }

                MessageBox.Show(tipo + " bem sucedido!");
            }catch(ArgumentException erro)
            {
                MessageBox.Show(string.Format("Erro :{0}", erro.Message));
                
            }catch(Exception erro)
             {
                MessageBox.Show(erro.Message);
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                if (e.KeyChar == ',')
                   e.Handled = txt.Text.Contains(",") == true? true: false;
                else
                e.Handled = true;
            }
            
                
        }

        private void txtcodbrr_Validated(object sender, EventArgs e)
        {
            textBox3_KeyDown(sender, new KeyEventArgs(Keys.Enter));
        }

        

        private void txtcompra_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = double.Parse(string.IsNullOrEmpty(txt.Text) ? "0" : txt.Text).ToString("N").Trim();
        }

        private void txtDescricao_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;
            if(string.IsNullOrEmpty(txt.Text))
            {
                e.Cancel = true;
                
                this.errorProvider1.SetError(txt, "Descrição não pode ser vazia");
                
            }
        }

        private void txtcompra_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            txt.Text = txt.Text.Replace(".", "");
        }
    }
}
