using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercMarcelo.Dados.Entidades
{
    class Produtos : Crud
    {
        public Produtos()
            : base()
        {
            strInsert = @"insert into tbl_Produtos (
                [Descricao]
               ,[Codig_Barras]
               ,[Categoria]
               ,[Marca]
               ,[Und_Medida]
               ,[Preco_Compra]
               ,[Preco_Venda]
                ,Qtd_Entrada
               
               ,Qtd_Saida
                ,[Qtd_Atual]) values (
                @desc
               ,@codbrr
               ,@categ
               ,@marc
               ,@medida
               ,@comp
               ,@vend
               ,@qtd
               ,@said
               ,@qtdAtual) 
              ";
            strUpdate = @"UPDATE [dbo].[tbl_Produtos]
   SET [Descricao] = @desc
      ,[Codig_Barras] = @codbrr
      ,[Categoria] = @categ
      ,[Marca] = @marc
      ,[Und_Medida] =@medida
      ,[Preco_Compra] = @comp
      ,[Preco_Venda] = @vend
      ,[Qtd_Entrada] = @qtd
      ,[Qtd_Saida] = @said
      ,[Qtd_Atual] = @qtdAtual
 WHERE id_produto = @id_produto";
        }
        public Produto LerCodigoDeBarras(string Codigo, out Tranzacoes tran)
        {
            
            List<Produto> pro = SelectToList(string.Format("select * from tbl_produtos where Codig_Barras = '{0}'", Codigo)).ToListProduto();
            if(pro.Count == 0)
            {
                tran = Tranzacoes.Cadastro;
                return new Produto();
            }
            else if(pro.Count>1)
            {
                tran = Tranzacoes.indef;
                throw new ArgumentException("Existe mais de uma produto com este mesmo codigo de barras");
            }
            else
            {
                tran = Tranzacoes.Modificacao;
                return pro[0];
                
            }
        }
        public override void CarregaOsDados(List<Entidade> lista, System.Data.SqlClient.SqlDataReader li)
        {
            Produto use = new Produto();
            
            lista.Add(use.SetPropert( li));
        }
    }
}
