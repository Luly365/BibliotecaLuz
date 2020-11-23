using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class RepositorioGeneros
    {
        private readonly SqlConnection _conexion;

        public RepositorioGeneros(SqlConnection conexion)
        {
            _conexion = conexion;
        }
        public List<Genero> GetGenero()
        {
            List<Genero> lista = new List<Genero>();
            try
            {

                string cadenaComando = "SELECT GeneroId, Descripcion FROM Generos";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    Genero genero = ConstruirGenero(reader);
                    lista.Add(genero);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private Genero ConstruirGenero(SqlDataReader reader)
        {
            return new Genero
            {
                generoId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public void Agregar(Genero genero)
        {
            try
            {
                var cadenaComando = "INSERT INTO Generos VALUES(@descripcion)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _conexion);

                genero.generoId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public Genero GetGeneroPorId(int id)
        {
            try
            {
                Genero genero = null;
                string cadenaComando = "SELECT GeneroId, Descripcion FROM Generos WHERE GeneroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    genero = ConstruirGenero(reader);
                }
                reader.Close();
                return genero;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Genero genero)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (genero.generoId == 0)
                {
                    var cadenaComando = "SELECT GeneroId, Descripcion FROM Generos WHERE Descripcion=@descripcion";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);

                }
                else
                {
                    var cadenaComando = "SELECT GeneroId, Descripcion FROM Generos WHERE Descripcion=@descripcion AND GeneroId<>@id";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                    comando.Parameters.AddWithValue("@id", genero.generoId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int GeneroId)
        {
            try
            {
                string cadenaComando = "DELETE FROM Generos WHERE GeneroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", GeneroId);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Editar(Genero genero)
        {
            try
            {
                string cadenaComando = "UPDATE Generos SET Descripcion=@descripcion WHERE GeneroId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@descripcion", genero.Descripcion);
                comando.Parameters.AddWithValue("@id", genero.generoId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }


}

