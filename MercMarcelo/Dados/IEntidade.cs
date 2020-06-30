using System.Data.SqlClient;

namespace MercMarcelo.Dados
{
    public interface IEntidade
    {
        SqlCommand getPropert();

    }
}
