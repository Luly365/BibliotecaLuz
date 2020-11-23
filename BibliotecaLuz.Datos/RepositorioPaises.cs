using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class RepositorioPaises
    {

        private readonly SqlConnection _conexion;

        public RepositorioPaises(SqlConnection conexion)
        {
            _conexion = conexion;
        }
        public List<Pais> GetPais()
        {
            List<Pais> lista = new List<Pais>();
            try
            {

                string cadenaComando = "SELECT PaisId, NombrePais FROM Paises";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    Pais pais = ConstruirPais(reader);
                    lista.Add(pais);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Pais ConstruirPais(SqlDataReader reader)
        {
            return new Pais
            {
                PaisId = reader.GetInt32(0),
                NombrePais = reader.GetString(1)
            };
        }

        public void Agregar(Pais pais)
        {
            try
            {
                var cadenaComando = "INSERT INTO Paises VALUES(@nombrePais)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@NombrePais", pais.NombrePais);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _conexion);

                pais.PaisId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Pais GetPaisPorId(int id)
        {
            try
            {
                Pais pais = null;
                string cadenaComando = "SELECT PaisId, NombrePais FROM Paises WHERE PaisId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    pais = ConstruirPais(reader);
                }
                reader.Close();
                return pais;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Pais pais)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (pais.PaisId == 0)
                {
                    var cadenaComando = "SELECT PaisId, NombrePais FROM Paises WHERE NombrePais=@NombrePais";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@NombrePais", pais.NombrePais);

                }
                else
                {
                    var cadenaComando = "SELECT PaisId, NombrePais FROM Paises WHERE NombrePais=@NombrePais AND PaisId<>@id";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombrePais", pais.NombrePais);
                    comando.Parameters.AddWithValue("@id", pais.PaisId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int PaisId)
        {
            try
            {
                string cadenaComando = "DELETE FROM Paises WHERE PaisId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", PaisId);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Editar(Pais pais)
        {
            try
            {
                string cadenaComando = "UPDATE Paises SET NombrePais=@nombrePais WHERE PaisId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombrePais", pais.NombrePais);
                comando.Parameters.AddWithValue("@id", pais.PaisId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
