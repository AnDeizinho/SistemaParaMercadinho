using FerramentasDeModelagem;
namespace MercMarcelo.Dados.Entidades
{
    
    internal class UndMedida : Entidade
    {
        [Colunas("nvarchar(20)", false)]
        public string Medida { get; set; }
        public UndMedida()
        {
            
        }
        public UndMedida(string med)
        {
            Medida = med;
        }
    }
}
