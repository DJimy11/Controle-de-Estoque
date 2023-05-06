using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace ControleDeEstoque.Web.Models
{
    public class UsuarioModel
    {
        public static bool ValidarUsuario(string login, string senha)
        {
            var ret = false;
            using (var conexao = new SqlConnection())
            {
<<<<<<< Updated upstream
                conexao.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=controle_estoque;Data Source=DESKTOP-ITD9051";
=======
<<<<<<< Updated upstream
                conexao.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=controle_estoque;Data Source=DESKTOP-E961UK4\SQLEXPRESS";
=======
                conexao.ConnectionString = @"Integrated Security=SSPI;Persist Security Info=False;User ID=admin;Initial Catalog=controle_estoque;Data Source=DUMILDE\DUMILDE";
>>>>>>> Stashed changes
>>>>>>> Stashed changes
                conexao.Open();
                using (var comando = new SqlCommand())
                {
                    comando.Connection = conexao;
                    comando.CommandText = string.Format(
                        "select count(*) from usuario where login='{0}' and senha='{1}'", login, senha);
                    ret = ((int)comando.ExecuteScalar() > 0);
                }
            }
            return ret;
        }
    }
}