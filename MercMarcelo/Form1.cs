using System;
using MercMarcelo.Dados.Entidades;
using System.Windows.Forms;

namespace MercMarcelo
{
    public partial class frmUsuario : Form
    {
        public frmUsuario()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            Usuarios users = new Usuarios();
            try
            {
                Usuario usu = users.Logar(txtUsuario.Text, txtSenha.Text);
                this.Visible = false;
                new frmMenu(usu).Show();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
            
        }


    }
}
