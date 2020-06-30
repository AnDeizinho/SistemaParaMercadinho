using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace FerramentasDeModelagem
{
    public class CriarTabelas
    {
        public string GetCommando { get => MontarString(); }
        public string NomeTabela { get; set; }
        public CollectionColunas TodasColunas { get; set; } = new CollectionColunas();
        public CriarTabelas()
        { }
        public CriarTabelas(string nome,object obj)
        {
            NomeTabela = nome;
            foreach (var i in obj.GetType().GetProperties())
            {
                foreach(Colunas atrib in i.GetCustomAttributes(typeof(Colunas), false))
                {
                    atrib.Nome = i.Name;
                    TodasColunas.Add(atrib);
                }
            }
            
        }
        string MontarString()
        {
            return $"CREATE TABLE [{NomeTabela}] ({TodasColunas.ToString()})";
        }
    }
}
