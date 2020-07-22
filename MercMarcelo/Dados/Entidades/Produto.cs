using System;
using System.Data.SqlClient;
using System.Runtime.Remoting.Messaging;
using FerramentasDeModelagem;

namespace MercMarcelo.Dados.Entidades
{
    class Produto : Entidade
    {
        double compra;
        string _descr;
        string _cdbarrs;
        string _cat , _marca;

        [Colunas("int", true, true)]
        public int id_produto { get; set; }
        [Colunas("nvarchar(50)", false)]
        public string Descricao { get { return _descr; } set
            {
                _descr = ValidaStr(value, "Descrição", 50);
            }
        }
        [Colunas("nvarchar(14)", false)]
        public string Codig_Barras { get => _cdbarrs; set {
                _cdbarrs = ValidaStr(value, "Código de Barras", 14);
                    } }
        [Colunas("nvarchar(50)", false)]
        public string Categoria { get => _cat; set => _cat = ValidaStr(value, "Categoria", 50); }

        [Colunas("nvarchar(30)", false)]
        public string Marca { get => _marca; set => _marca = ValidaStr(value, "Marca", 30); }
        [Colunas("decimal(6,2)", false)]
        public string Und_Medida { get; set; }
        [Colunas("decimal(9,2)", false)]
        public double Preco_Compra { get { return compra; } 
            set 
            {
                if (value < 0)
                    throw new ArgumentException("Preço de compra não pode ser negativo");
                else
                    compra = value;
            } }
        [Colunas("decimal(9,2)", false)]
        double venda;
        public double Preco_Venda { 
            get 
            { 
                return venda; 
            }
            set {
                if (Preco_Compra <= value)
                    venda = value;
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
        string ValidaStr(string Valor, string msg, int tamanho)
        {
            if (Valor.Length > tamanho)
                throw new ArgumentException(msg + " deve ter no máximo " + tamanho + " caracteres");
            if (string.IsNullOrEmpty(Valor))
                throw new ArgumentException(msg + " não pode ser nulo",msg);
            return Valor;
        }
        public override SqlCommand getPropert()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Parameters.AddWithValue("@id_produto", id_produto);
            cmd.Parameters.AddWithValue("@codbrr", Codig_Barras);
            cmd.Parameters.AddWithValue("@desc", Descricao);
            cmd.Parameters.AddWithValue("@categ", Categoria);
            cmd.Parameters.AddWithValue("@marc", Marca);
            cmd.Parameters.AddWithValue("@medida", Und_Medida);
            cmd.Parameters.AddWithValue("@comp",Preco_Compra);
            cmd.Parameters.AddWithValue("@vend",Preco_Venda);
            cmd.Parameters.AddWithValue("@qtd",Qtd_Entrada);
            cmd.Parameters.AddWithValue("@said", Qtd_Saida );
            cmd.Parameters.AddWithValue("@qtdAtual", Qtd_Atual);
            cmd.Parameters.AddWithValue("@Data", DateTime.Now);
            return cmd;
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
       
        public Produto SetPropert(SqlDataReader leitor)
        {
            return  new Produto(int.Parse(leitor["id_produto"].ToString()), leitor["descricao"].ToString().Trim(),
                leitor["Codig_Barras"].ToString(), leitor["Categoria"].ToString().Trim(), leitor["Marca"].ToString().Trim(),
                leitor["Und_Medida"].ToString().Trim(), double.Parse(leitor["Preco_Compra"].ToString()), double.Parse(leitor["Preco_Venda"].ToString()),
                double.Parse(leitor["Qtd_Entrada"].ToString()), double.Parse(leitor["Qtd_Saida"].ToString()));
        }
    }
}
   


