using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace MercMarcelo.Dados.Entidades
{
    internal enum Movimentacao { Retirada, Entrada}
    internal class Estoque : Crud
    {
        //atributos locais
        int _id;
        Produto _prod;
        double _saida, _entrada, _anterior, _posterior;
        DateTime _data;
        //Propriedades e suas regras
        public int Id_histórico { get => _id; set => _id = value; }
        public int Id_Produto { get => produto.id_produto;  }
        public double Saida { get => _saida; set
            {
                if ( value < 0)
                    throw new ArgumentException("a Saida não pode ser maior que a entrada e nem pode ser negativo", "Saida");
                _saida = value;
            } }
        public double Entrada { get => _entrada; set
            {
                if (value < 0)
                    throw new ArgumentException("Entrada não pode ser negativa", "Entrada");
                _entrada = value;
            } }
        public double Venda { get => produto.Preco_Venda;  }
        public double Compra { get => produto.Preco_Compra;}
        public double Saldo_Anterior { get => _anterior; set => _anterior = value; }
        public double Saldo_Posterior { get => _posterior; set => _posterior = value; }
        public DateTime Data { get => _data; set => _data = value; }
        
        public Produto produto { get => _prod; set
            {
                if (value == null)
                    throw new NullReferenceException("Referência ao produto é nula");
                if (value.id_produto == 0)
                    throw new ArgumentException("O id do produto não pode ser 0");
                _prod = value;
            }
        }
        //Contrutores 
        
        public Estoque(Produto prod)
        {

            produto = prod;
            
        }
         //Metodos privados

         void DarEntradaNoEstoque( double Entrada, double Saida = 0)
        {
            this.Saida = Saida;
            this.Entrada = Entrada;
            Saldo_Anterior = produto.Qtd_Atual - produto.Qtd_Entrada;
            Saldo_Posterior = produto.Qtd_Atual;

            Data = DateTime.Now;

            SalvarNoBD();
        }
         void DarSaidaNoEstoque(double Saida, double Entrada = 0)
        {
            this.Saida = Saida;
            this.Entrada = Entrada;
            Saldo_Anterior = produto.Qtd_Atual + Saida;
            Saldo_Posterior = produto.Qtd_Atual;

            Data = DateTime.Now;

            SalvarNoBD();
        }
        void SalvarNoBD()
        {
            try
            {
                SqlCommand cmd = new SqlCommand(@"insert into tbl_Estoque values(
                @id_prod
               ,@Said
               ,@Entrada
               ,@data
               ,@Venda
               ,@Compra
               ,@Antes
               ,@Depois)", con);
                cmd.Parameters.AddWithValue("@id_prod", Id_Produto);
                cmd.Parameters.AddWithValue("@Said", Saida);
                cmd.Parameters.AddWithValue("@Entrada", Entrada);
                cmd.Parameters.AddWithValue("@Venda", Venda);
                cmd.Parameters.AddWithValue("@Compra", Compra);
                cmd.Parameters.AddWithValue("@Antes", Saldo_Anterior);
                cmd.Parameters.AddWithValue("@Depois", Saldo_Posterior);
                cmd.Parameters.AddWithValue("@data", Data);
                cmd.Connection.Open();
                if (cmd.ExecuteNonQuery() == -1)
                    throw new Exception(infoErros);
                
            }
            catch(Exception erro)
            {
                
                throw erro;
            }
            finally{
                con.Close();

            }
        }
        //Métodos publicos
        public void Movimentar(double Saida, double Entrada, Movimentacao mov)
        {
            switch(mov)
            {
                case Movimentacao.Entrada:
                    DarEntradaNoEstoque(Entrada);
                    break;
                case Movimentacao.Retirada:
                    DarSaidaNoEstoque(Saida);
                    break;
            }
        }
        


    }
}
