using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercMarcelo.Dados.Entidades
{
    class Produtos : Crud
    {
        public Produtos()
            : base()
        {

        }
        public override void CarregaOsDados(List<Entidade> lista, System.Data.SqlClient.SqlDataReader li)
        {
            Produto use = new Produto();
            use.SetPropert(use, li);
            lista.Add(use);
        }
    }
}
