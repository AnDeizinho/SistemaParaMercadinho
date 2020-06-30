using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using MercMarcelo.Dados.Entidades;
using MercMarcelo.Dados;
namespace MercMarcelo
{
   
    
    public static class Extensoes
    {
        public static Dados.Entidades.Usuario ToUsuario(this Entidade ent)
        {
            Usuario user = (Usuario)ent;

            return user;

        }
        public static List<Usuario> ToListUsuario(this List<Entidade> lis)
        {
            List<Usuario> user = new List<Usuario>();
            foreach (Entidade i in lis)
            {
                user.Add(i.ToUsuario());
            }
            return user;
        }
        internal static List<Produto> ToListProduto(this List<Entidade> lis)
        {
            List<Produto> prod = new List<Produto>();
            foreach(Entidade i in lis)
            {
                prod.Add(i.ToProduto());
            }
            return prod;
        }
        internal static Produto ToProduto(this Entidade prod)
        {
            return (Produto)prod;
        }
        internal static List<Categoria> ToListCategorias(this List<Entidade> ent)
        {
            List<Categoria> cate = new List<Categoria>();
            foreach(Entidade i in ent)
            {
                cate.Add((Categoria)i);
            }
            return cate;
        }
        internal static List<UndMedida> ToListMedidas(this List<Entidade> ent)
        {
            List<UndMedida> medidas = new List<UndMedida>();
            foreach (Entidade i in ent)
                medidas.Add((UndMedida)i);
            return medidas;
        }

    }
    
}
