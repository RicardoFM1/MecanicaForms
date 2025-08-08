
using MySql.Data.MySqlClient;



namespace Mecanica.Database
{
    public class Conexao
    {
        private const string connectionString = "server=mysql-planosite.alwaysdata.net;port=3306;database=planosite_mecanica;user=planosite_mecuse;password=1234567890987654321!@#$%¨&*();";

        public static MySqlConnection ObterConexao()
        {
            var conexao = new MySqlConnection(connectionString);
            conexao.Open();
            return conexao;
        }
    }
}