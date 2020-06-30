
using System.Windows.Forms;
using MercMarcelo.Dados.Entidades;
using System.Collections.Generic;
using System;
using MercMarcelo.Dados;
using MercMarcelo.Controles;

namespace MercMarcelo.Produtos
{
    public partial class CadastroProdutocs : UserControl
    {
        Produto prod;
        TextBoxDinheiro boxDinheiro;
        public CadastroProdutocs()
        {
            
            InitializeComponent();
            boxDinheiro = new TextBoxDinheiro();
            groupBox1.Controls.Add(boxDinheiro);
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

                    List<Produto> li = pro.SelectToList($"select * from tbl_Produtos where Codig_Barras = '{txtcodbrr.Text}'").ToListProduto();
                    if (li.Count > 0 && li.Count < 2)
                    {
                        prod = li[0];
                        carregaControles(prod);
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
            
        }

      
        private void button1_Click(object sender, EventArgs e)
        {
            Controles.Colecao col = new Controles.Colecao(new Dados.Categorias());
            col.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Controles.Colecao co = new Controles.Colecao(new Dados.Entidades.UndMedidas());
            co.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //prod = new Produto(0,)
        }
    }
}
