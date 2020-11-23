using System.Data.SqlClient;

namespace BibliotecaLuz.Servicios
{
    internal class RepositorioPais
    {
        private SqlConnection sqlConnection;

        public RepositorioPais(SqlConnection sqlConnection)
        {
            this.sqlConnection = sqlConnection;
        }
    }
}