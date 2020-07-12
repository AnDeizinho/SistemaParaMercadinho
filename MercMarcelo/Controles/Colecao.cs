using MercMarcelo.Dados;
using System;
using MercMarcelo.Dados.Entidades;
using System.Windows.Forms;
using System.Collections.Generic;

namespace MercMarcelo.Controles
{
    public partial class Colecao : Form
    {
        Crud crud;
        internal Colecao(Categorias cat)
        {
            crud = cat;
            InitializeComponent();
            foreach(Categoria i in cat.SelectToList("select * from tbl_Categorias").ToListCategorias())
            {
                Lista.Items.Add(i);
            }
            Lista.ValueMember = "Descricao";
            Lista.DisplayMember = "Descricao";
            tbnAdd.Click += new EventHandler(adicionarCategoria);
        }
        
        internal Colecao(UndMedidas med) 
        {
            crud = med;
            InitializeComponent();
            foreach (UndMedida i in med.SelectToList("select * from tbl_UndMedidas").ToListMedidas())
            {
                Lista.Items.Add(i);
            }
            Lista.ValueMember = "Medida";
            Lista.DisplayMember = "Medida";
            tbnAdd.Click += new EventHandler(adicionarMedida);
        }
        void adicionarCategoria(object sender, EventArgs e)
        {
            try
            {
                Categoria cate = new Categoria(textBox1.Text);
                crud.ModificarOuAlterar(Tranzacoes.Cadastro, cate);
                Lista.Items.Add(cate);
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void adicionarMedida(object sender, EventArgs e)
        {
            try
            {
                UndMedida med = new UndMedida(textBox1.Text);
                crud.ModificarOuAlterar(Tranzacoes.Cadastro, med);
                Lista.Items.Add(med);
            }catch(Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

    }
    
}
