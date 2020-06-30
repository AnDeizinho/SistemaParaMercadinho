using MercMarcelo.Dados;
using MercMarcelo.Dados.Entidades;

namespace MercMarcelo.Controles
{
    internal delegate void RestringirPermissao(System.Windows.Forms.Control controle);
    internal sealed class Permissoes : IPermissoes
    {
        internal Usuario User {get; private set;}
        internal RestringirPermissao SetAdmin {get; private set;}
        internal RestringirPermissao SetAlmoxarifado { get; private set; }
        internal RestringirPermissao SetCaixa{get;private set;}
        internal Permissoes(Usuario usu, RestringirPermissao adm, RestringirPermissao almox, RestringirPermissao caix , System.Windows.Forms.Control cont)
        {
            User = usu;
            SetAdmin = adm;
            SetAlmoxarifado = almox;
            SetCaixa = caix;
            Definir(cont);
        }

        public  void Definir(System.Windows.Forms.Control cont)
        {
            switch (User.Acesso)
            {
                case NiveisAcesso.Adimin:
                    SetAdmin(cont);
                    break;
                case NiveisAcesso.Caixa:
                    SetCaixa(cont);
                    break;
                case NiveisAcesso.Almoxarifado:
                    SetAlmoxarifado(cont);
                    break;
            }
        }
        
    }
}
