
using System.Collections.Generic;

using System.Data.SqlClient;
namespace MercMarcelo.Dados.Entidades
{
    public class Usuarios : Dados.Crud
    {

        public Usuarios() : base()
        {
            strInsert = @"if (select COUNT(0) from tbl_usuarios where [Login] = @Login) = 0 
                                                        INSERT INTO [bd_Mercadinho].[dbo].[tbl_usuarios]
                                                               ([Login]
                                                               ,[Senha]
                                                               ,[Acesso])
                                                         VALUES
                                                               (@Login
                                                               ,@Senha
                                                               ,@Acesso)

                                                    else 
	                                                    print ('ja existe um usuario cadastrado com este nome')";
            strSelect = "select * from tbl_usuarios";
            strUpdate = @"
                                                        update [bd_Mercadinho].[dbo].[tbl_usuarios]
                                                                set 
                                                               [Login] = @login
                                                               ,[Senha] = @senha
                                                               ,[Acesso] = @Acesso
                                                         where id_usuario = @id_usuario

                                                 ";
            strDelete = "delete from tbl_usuarios where id_usuario = @id_usuario";
        }
        public override void CarregaOsDados(List<Entidade> lista, SqlDataReader li)
        {

            Usuario use = new Usuario();
            use.SetPropert(use, li);
            lista.Add(use);

        }


        public Usuario Logar(string login, string senha)
        {

            System.Data.DataTable tbl = Select(string.Format("select * from tbl_usuarios where Login = '{0}' and senha = '{1}'", login, senha));
            return new Usuario(int.Parse(tbl.Rows[0]["id_usuario"].ToString()), tbl.Rows[0]["login"].ToString(), tbl.Rows[0]["senha"].ToString(), (NiveisAcesso)int.Parse(tbl.Rows[0]["acesso"].ToString()));

        }

    }
}
