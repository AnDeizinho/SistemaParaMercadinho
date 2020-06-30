using System;
using System.Collections.Generic;
using System.Text;

namespace FerramentasDeModelagem
{
    public class Colunas : Attribute
    {
        string _nome;
        public string Nome { get => $"[{_nome}]"; set => _nome = value; }
        public string Tipo { get; set; }
        public Chave key;
        public Nullos PermNulos; 
        public Colunas(string tipo, bool nulos)
        {
           Tipo = $"{tipo}"; PermNulos = new Nullos(nulos);
        }
        public Colunas( string tipo, bool chave, bool altoIncrement)
        {
             Tipo = $"[{tipo}]"; this.key = new Chave(chave, altoIncrement); PermNulos = new Nullos(false);
        }
        public override string ToString()
        {
            return $"{Nome} {Tipo} {key} {PermNulos}";
        }


    }
}
