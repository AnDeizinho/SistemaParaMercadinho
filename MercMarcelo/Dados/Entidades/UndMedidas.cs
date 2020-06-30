
using System.Collections.Generic;
using System.Data.SqlClient;

namespace MercMarcelo.Dados.Entidades
{
    internal class UndMedidas : Crud
    {
        public UndMedidas() : base()
        {
            this.strInsert = "if(select count(0) from tbl_UndMedidas where Medida = @Medida) = 0" +
                "insert into tbl_UndMedidas (Medida) values (@Medida) else print('já existe uma unidade de medida cadastrada assim')";
        }
        public override void CarregaOsDados(List<Entidade> lista, SqlDataReader li)
        {
            UndMedida med = new UndMedida();
            med.SetPropert(med, li);
            lista.Add(med);
        }
    }
}
