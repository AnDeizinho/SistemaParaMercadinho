using System;
using System.Collections.Generic;

using System.Data;

namespace MercMarcelo.Dados
{
    interface ICrud
    {

        DataTable Select(string cmd);
        void Deletar(Entidade ent, string cmd);
        void ModificarOuAlterar(Tranzacoes tranz, Dados.IEntidade ent, string cmd = "");


    }
}
    

   
   
   