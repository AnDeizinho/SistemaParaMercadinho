using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

using MercMarcelo.Dados.Entidades;
namespace MercMarcelo
{
    internal partial class frmMenu : Form
    {
        Controles.Permissoes permi;
        public frmMenu(Usuario u)
        {
            
            InitializeComponent();
            permi = new Controles.Permissoes(u, adm, Alm, caixa, this);

            
        }
        private void adm(Control cont)
        {
            this.btnUsuarios.Enabled = true;
        }
        private void caixa(Control cont)
        {
            this.btnUsuarios.Enabled = false;
        }
        private void Alm(Control cont)
        {
            this.btnUsuarios.Enabled = false;
        }
        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            UIUsuarios.ucUsuarios ui = new UIUsuarios.ucUsuarios();
            ui.Location = new Point(100, 5);
            abrirControle(ui);

        }
        void abrirControle(UserControl contr)
        {
            if (pn.Controls.Count > 0)
            {
                if (pn.Controls[0].GetType().Equals(contr.GetType()))
                    return;
            }
            pn.Controls.Clear();
            
            pn.Controls.Add(contr);
        }
        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Produtos.CadastroProdutocs cd = new Produtos.CadastroProdutocs();
            abrirControle(cd);
        }



       
    }
}
