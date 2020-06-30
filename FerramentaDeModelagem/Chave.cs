using System;
using System.Collections.Generic;
using System.Text;

namespace FerramentasDeModelagem
{
    public struct Chave 
    {
        bool Iskey;
        bool IsAutoIncrement;

        int de, para;

        public Chave(bool Echave = false, bool Increment = false, int um = 1, int paraTanto = 1)
        {
            Iskey = Echave; IsAutoIncrement = Increment; de = um; para= paraTanto;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += Iskey ? "IDENTITY" : "";
            retorno += IsAutoIncrement ? $"({de},{para})" : "";
            return retorno;
        }
    }
}
