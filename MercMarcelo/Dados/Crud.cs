using System;
using System.Collections.Generic;

using System.Data;
using System.Data.SqlClient;
namespace MercMarcelo.Dados
{
    public abstract class Crud : ICrud
    {
        protected SqlConnection con;
        protected SqlDataAdapter adp;
        public string strInsert;
        public string strSelect;
        public string strUpdate;
        public string strDelete;
        public string NomeTabela;
        protected string infoErros;

        public Crud()
        {

            con = new SqlConnection(@"Data Source = monica ; database = bd_mercadinho ; user Id = sa; password = yerdna");
            adp = new SqlDataAdapter();
            con.InfoMessage += con_InfoMessage;

        }

        void con_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            infoErros = e.Message;
        }
        public System.Data.DataTable Select(string cmd = "")
        {
            if (cmd == "")
                cmd = strSelect;
            DataTable tbl;
            try
            {
                tbl = new DataTable();
                adp.SelectCommand = new System.Data.SqlClient.SqlCommand(cmd, con);
                adp.Fill(tbl);
                if (tbl.Rows.Count == 0)
                    throw new Exception("nenhum registro encontrado");
                return tbl;
            }
            catch (Exception erro)
            {
                throw erro;

            }
            finally
            {
                con.Close();

            }


        }
        public virtual void CarregaOsDados(List<Entidade> lista, SqlDataReader li)
        {
            
                    //Entidade use = new Entidade();
                    //use.SetPropert(use, li);
                    //lista.Add(use);
                
        }
        public List<Entidade> SelectToList(string cmd = "")//tem que receber um metodo como argumento
        {
            if (cmd == "")
                cmd = strSelect;
            List<Entidade> tbl;
            try
            {
                tbl = new List<Entidade>();
                adp.SelectCommand = new System.Data.SqlClient.SqlCommand(cmd, con);
                con.Open();
                var li = adp.SelectCommand.ExecuteReader();
                while (li.Read())
                {
                    CarregaOsDados(tbl, li);
                }

                return tbl;
            }
            catch (Exception erro)
            {
                throw erro;

            }
            finally
            {
                con.Close();

            }

        }

        public void Deletar(Entidade ent, string cmd = "")
        {
            if (cmd == "")
                cmd = strDelete;

            try
            {
                this.adp.DeleteCommand = ent.getPropert();
                adp.DeleteCommand.Connection = con;
                adp.DeleteCommand.CommandText = cmd;

                con.Open();
                int retorno = this.adp.DeleteCommand.ExecuteNonQuery();
                if (retorno == -1)
                    throw new ApplicationException("Falha ao deletar");
            }
            catch (Exception erro)
            {
                System.Windows.Forms.MessageBox.Show(erro.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void ModificarOuAlterar(Tranzacoes tranz, Dados.IEntidade ent, string cmd = "")
        {
            if (cmd == "" && tranz == Tranzacoes.Modificacao)
                cmd = strUpdate;
            else if (cmd == "" && tranz == Tranzacoes.Cadastro)
                cmd = strInsert;
            try
            {

                SqlCommand comando= ent.getPropert();
                comando.Connection = con;
                comando.CommandText = cmd;
                con.Open();
                if (comando.ExecuteNonQuery() == -1)
                    throw new Exception(infoErros);

            }
            catch (Exception erro)
            {
                throw erro;
            }
            finally
            {
                con.Close();
            }
        }

    }
}
