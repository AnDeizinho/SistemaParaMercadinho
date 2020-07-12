using System;
using System.Data.SqlClient;

namespace MercMarcelo.Dados
{
    public abstract class Entidade : IEntidade
    {

        public virtual SqlCommand getPropert()
        {
            SqlCommand cmd = new SqlCommand();

            foreach (var p in this.GetType().GetProperties())
            {
                cmd.Parameters.AddWithValue("@" + p.Name, p.GetValue(this));
            }

            return cmd;
        }
        public virtual void SetPropert(Entidade ent, SqlDataReader leitor)
        {


            foreach (var p in ent.GetType().GetProperties())
            {
                try
                {
                    p.SetValue(this, leitor[p.Name]);
                }
                catch (IndexOutOfRangeException)
                {
                    continue;
                }
            }



        }
    }



}

