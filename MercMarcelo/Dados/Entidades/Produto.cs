using System;
using FerramentasDeModelagem;

namespace MercMarcelo.Dados.Entidades
{
    class Produto : Entidade
    {
        [Colunas("int", true, true)]
        public int id_produto { get; set; }
        [Colunas("nvarchar(50)", false)]
        public string Descricao { get; set; }
        [Colunas("nvarchar(14)", false)]
        public string Codig_Barras { get; set; }
        [Colunas("nvarchar(50)", false)]
        public string Categoria { get; set; }
        [Colunas("nvarchar(30)", false)]
        public string Marca { get; set; }
        [Colunas("decimal(6,2)", false)]
        public string Und_Medida { get; set; }
        [Colunas("decimal(9,2)", false)]
        public double Preco_Compra { get { return Preco_Compra; } 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Preço de compra não pode ser negativo");
                else
                    Preco_Compra = value;
            } }
        [Colunas("decimal(9,2)", false)]
        public double Preco_Venda { 
            get 
            { 
                return Preco_Venda; 
            }
            set {
                if (Preco_Compra <= value)
                    Preco_Venda = value;
                else
                    throw new ArgumentException("O preço de venda tem que ser maior ou igual o preço de compra");
            } }
        [Colunas("decimal(6,2)", false)]
        public double Qtd_Entrada { get; set; }
        [Colunas("decimal(6,2)", false)]
        public double Qtd_Saida { get; set; }
        [Colunas("decimal(6,2)", false)]
        public double Qtd_Atual
        {
            get
            {
                if (Qtd_Entrada < Qtd_Saida)
                    throw new Exception("inconsistencia de dados, pos a entrada é menos que a saída e o saldo esta negativo");
                return Qtd_Entrada - Qtd_Saida;
            }
        }
        
        public Produto()
            : base()
        {

        }
        public Produto(int id,string Descr, string Barras ,string Cat,string marca, string Medida , double Compra 
        , double Venda ,double Entrada,double Saida )
        {
           id_produto = id;
         Descricao  = Descr;
         Codig_Barras = Barras;
         Marca = marca;
         Categoria = Cat;
         Und_Medida= Medida;
         Preco_Compra = Compra;
         Preco_Venda =Venda;
         Qtd_Entrada = Entrada;
         Qtd_Saida = Saida;
          
        }

        public object this[int i]
        {
            get
            {
               
                
                    if(i== 0) return id_produto;

                else if (i == 1) return Descricao;

                else if (i == 2) return Codig_Barras;

                else if (i == 3) return Categoria;

                else if (i == 4) return Marca;

                 else if (i == 5) return Und_Medida;

                    else if (i == 6) return Preco_Compra;

                   else if (i == 7) return Preco_Venda;

                    else if (i == 8) return Qtd_Entrada;

                   else if (i == 9) return Qtd_Saida;

                   else if (i == 10)
                        return Qtd_Atual;
                    else
                        throw new ArgumentOutOfRangeException("o indice estava fora do intervalo");
            }
        }
    }
}
   


