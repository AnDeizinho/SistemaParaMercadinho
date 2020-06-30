using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MercMarcelo.Dados.Entidades
{
    public class Usuario : Dados.Entidade
    {
        string log, sen;
        int acesso;
        public int Id_Usuario { get; set; }
        public string Login { get { return log; } set { log = value.Trim(); } }
        public string Senha { get { return sen; } set { sen = value.Trim(); } }
        public NiveisAcesso Acesso
        {
            get { return (NiveisAcesso)acesso; }
            set
            {
                acesso = (int)value;
            }
        }
        public Usuario(int id, string login, string senha, NiveisAcesso acesso) : base()
        {
            Id_Usuario = id;
            Login = login;
            sen = senha;
            Acesso = acesso;
        }
        public Usuario() : base()
        {

        }



    }
}
