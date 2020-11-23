using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class RepositorioAutores
    {
        private readonly SqlConnection _conexion;

        public RepositorioAutores(SqlConnection conexion)
        {
            _conexion = conexion;
        }
        public List<Autor> GetAutor()
        {
            List<Autor> lista = new List<Autor>();
            try
            {

                string cadenaComando = "SELECT AutorId, NombreAutor FROM Autores";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    Autor autor = ConstruirAutor(reader);
                    lista.Add(autor);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Autor ConstruirAutor(SqlDataReader reader)
        {
            return new Autor
            {
                AutorId = reader.GetInt32(0),
                NombreAutor = reader.GetString(1)
            };
        }

        public void Agregar(Autor autor)
        {
            try
            {
                var cadenaComando = "INSERT INTO Autores VALUES(@nombreAutor)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _conexion);

                autor.AutorId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Autor GetAutorPorId(int id)
        {
            try
            {
                Autor autor = null;
                string cadenaComando = "SELECT AutorId,NombreAutor FROM Autores WHERE AutorId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    autor = ConstruirAutor(reader);
                }
                reader.Close();
                return autor;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Autor autor)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (autor.AutorId == 0)
                {
                    var cadenaComando = "SELECT AutorId, NombreAutor FROM Autores WHERE NombreAutor=@nombreAutor";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);

                }
                else
                {
                    var cadenaComando = "SELECT AutorId, NombreAutor FROM Autores WHERE NombreAutor=@nombreAutor AND AutorId<>@id";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);
                    comando.Parameters.AddWithValue("@id", autor.AutorId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int AutorId)
        {
            try
            {
                string cadenaComando = "DELETE FROM Autores WHERE AutorId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", AutorId);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Editar(Autor autor)
        {
            try
            {
                string cadenaComando = "UPDATE Autores SET NombreAutor=@nombreAutor WHERE AutorId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombreAutor", autor.NombreAutor);
                comando.Parameters.AddWithValue("@id", autor.AutorId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
