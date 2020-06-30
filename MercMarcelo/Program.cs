using System;

using System.Data.SqlClient;
using System.Windows.Forms;
using FerramentasDeModelagem;
using MercMarcelo.Dados.Entidades;

namespace MercMarcelo
{
    static class Program
    {
        static void criarTabela(string valor, object obj)
        {
            CriarTabelas cri = new CriarTabelas(valor, obj);
            SqlCommand cmd = new SqlCommand(cri.GetCommando, new SqlConnection(@"Data Source = monica ; Database = bd_mercadinho ; User Id = sa ; Password = yerdna"));
            try
            {
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();

            }
            catch (Exception erro)
            {
                Console.WriteLine(erro.Message);
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
       
        [STAThread]
        static void Main()
        {
            /////criarTabela("tbl_UndMedidas", new UndMedida());
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmUsuario());
        }
    }
}
