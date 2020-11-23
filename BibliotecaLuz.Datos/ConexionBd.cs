using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class ConexionBd
    {
        private readonly SqlConnection _sqlConnection;
        public ConexionBd()
        {
            
                var cadenaConexion = ConfigurationManager.ConnectionStrings["Miconexion"].ToString();
                _sqlConnection = new SqlConnection(cadenaConexion);
            
           
        }
        public SqlConnection AbrirConexion()
        {
            if (_sqlConnection.State == ConnectionState.Closed)
            {
                _sqlConnection.Open();
            }
            return _sqlConnection;
        }
        public void CerrarConexion()
        {
            if (_sqlConnection.State == ConnectionState.Open)
            {
                _sqlConnection.Close();
            }
        }
    }
}
