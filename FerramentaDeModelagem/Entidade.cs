using System;
using System.Collections.Generic;
using System.Text;

namespace FerramentasDeModelagem
{
    class Entidade
    {
        [Colunas("int", true, true)]
        public int id_tabela { get; set; }
        [Colunas("nchar(50)",false)]
        public string descricao { get; set; }
        [Colunas("int", true)]
        public int quantidade { get; set; }
    }
}
