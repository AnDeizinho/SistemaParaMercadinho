using System;
using System.Collections.Generic;
using MercMarcelo.Dados.Entidades;
using System.Data.SqlClient;


namespace MercMarcelo.Dados
{
    internal class Categorias:Crud
    {
        public Categorias()
        {
            this.strInsert = @"if (select count(0) from tbl_Categorias where Descricao = @Descricao) = 0
INSERT INTO[dbo].[tbl_Categorias]
            ([Descricao])
     VALUES
           (@Descricao)
else print('já existe uma categoria com esta descrição')";
        }

        public override void CarregaOsDados(List<Entidade> lista, SqlDataReader li)
        {
            Categoria use = new Categoria();
            use.SetPropert(use, li);
            lista.Add(use);
        }
    }
}
