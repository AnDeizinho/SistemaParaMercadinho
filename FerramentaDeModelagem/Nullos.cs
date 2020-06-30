using System;
using System.Collections.Generic;
using System.Text;

namespace FerramentasDeModelagem
{
    public struct Nullos
    {
        bool _nulos;
        public override string ToString()
        {
            return _nulos ? "" : "Not Null";
        }
        public Nullos(bool PermitirNulos)
        {
            _nulos = PermitirNulos;
        }
    }
}
