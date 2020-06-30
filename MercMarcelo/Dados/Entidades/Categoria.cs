
using FerramentasDeModelagem;
using System;

namespace MercMarcelo.Dados.Entidades
{
    
    public class Categoria : Entidade
    {
        [Colunas("nvarchar (30)", false)]
        public string Descricao { get; set; }
        public Categoria(string desc)
        {
            Descricao = desc == "" ? throw new ArgumentException("Digite a descrição da Categoria") : desc;
            
        }
        public Categoria()
        {

        }
    }
}
