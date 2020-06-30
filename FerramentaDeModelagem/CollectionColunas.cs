using System;
using System.Collections.Generic;
using System.Text;

namespace FerramentasDeModelagem
{

    public class CollectionColunas : List<Colunas>
    {
        public override string ToString()
        {

            return getColunas(this);
        }
        string getColunas(List<Colunas> list, int ind = 0, string valor = "")
        {
            if (ind < list.Count)
            {
                if (ind == 0)
                    return getColunas(list, ind + 1, valor += "\n" + list[ind].ToString());
                return getColunas(list, ind + 1, valor += ",\n" + list[ind].ToString());
            }
            else
                return valor;
        }

    }
}
