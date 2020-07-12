
using System.Windows.Forms;
using MercMarcelo.Dados.Entidades;
using System.Collections.Generic;
using System;
using MercMarcelo.Dados;


namespace MercMarcelo.Produtos
{
    public partial class CadastroProdutocs : UserControl
    {
        Produto prod;
        
       
        public CadastroProdutocs()
        {
            
            InitializeComponent();
            
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
                        carregaControles(li[0]);
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
            txtcompra.Text = pro.Preco_Compra.ToString("C");
            txtvenda.Text = pro.Preco_Venda.ToString("C");
            txtqtd.Text = pro.Qtd_Entrada.ToString();
            
            
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
                prod = new Produto(0, txtDescricao.Text, txtcodbrr.Text, cbCategorias.Text, txtMarca.Text, cbMedida.Text, double.Parse(txtcompra.Text), double.Parse(txtvenda.Text),
                    double.Parse(txtqtd.Text), 0);

                MercMarcelo.Dados.Entidades.Produtos pro = new Dados.Entidades.Produtos();
                pro.ModificarOuAlterar(Tranzacoes.Cadastro, prod, @"insert into tbl_Produtos (
            [Descricao]
           ,[Codig_Barras]
           ,[Categoria]
           ,[Marca]
           ,[Und_Medida]
           ,[Preco_Compra]
           ,[Preco_Venda]
           ,[Qtd_Entrada]
           ,[Qtd_Saida]
           ,[Qtd_Atual]) values (
            @desc
           ,@codbrr
           ,@categ
           ,@marc
           ,@medida
           ,@comp
           ,@vend
           ,@qtd
           ,@said
           ,@qtdAtual)");
            }catch(Exception erro)
            {
                MessageBox.Show(erro.ToString());
            }
        }

        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!Char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        
    }
}
