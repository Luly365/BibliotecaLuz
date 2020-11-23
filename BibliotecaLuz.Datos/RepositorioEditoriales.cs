using BibliotecaLuz.Entidades.DTOs.Editorial;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class RepositorioEditoriales
    {
        private readonly SqlConnection _conexion;
        private readonly RepositorioPaises repositorioPaises;
       
        public RepositorioEditoriales(SqlConnection conexion, RepositorioPaises repositorioPais)
        {
            _conexion = conexion;
            repositorioPaises = repositorioPais;

        }
        public RepositorioEditoriales(SqlConnection cn)
        {
            _conexion = cn;
        }

        public void Borrar(Editorial editorial)
        {
            try
            {
                string cadenaComando = "DELETE FROM Editoriales WHERE EditorialId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Editorial> GetEditorial()
        {

            try
            {

                List<Editorial> lista = new List<Editorial>();
                string cadenaComando = "SELECT EditorialId, NombreEditorial,PaisId FROM Editoriales";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    Editorial editorial = ConstruirEditorial(reader);
                    lista.Add(editorial);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Editorial editorial)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (editorial.EditorialId == 0)
                {
                    var cadenaComando = "SELECT EditorialId, NombreEditorial, PaisId FROM Editoriales WHERE NombreEditorial=@nombreEditorial AND PaisId=@paisid";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombreEditorial", editorial.NombreEditorial);
                    comando.Parameters.AddWithValue("@paisId", editorial.Pais.PaisId);

                }
                else
                {
                    var cadenaComando = "SELECT EditorialId, NombreEditorial, PaisId FROM Editoriales WHERE NombreEditorial=@nombreEditorial AND PaisId=@paisid"+
                        "AND EditorialId<>@id";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombreEditorial", editorial.NombreEditorial);
                    comando.Parameters.AddWithValue("@paisId", editorial.Pais.PaisId);
                    comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public EditorialListDto GetLocalidadesporId(int id)
        {
            {
                try
                {
                    EditorialListDto editorialListDto = null;
                    string cadenaComando = "SELECT EditorialId, NombreEditorial FROM Editorial WHERE Editorial=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        editorialListDto = ConstruirEditorialDto(reader);
                        reader.Close();
                    }
                    return editorialListDto;
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
        }

        private EditorialListDto ConstruirEditorialDto(SqlDataReader reader)
        {
            return new EditorialListDto
            {
                EditorialId = reader.GetInt32(0),
                NombreEditorial = reader.GetString(1)
            };
        }

        public void Editar(Editorial editorial)
        {
            try
            {
                var cadenaComando = "UPDATE Editoriales SET NombreEditorial=@nombreEditorial WHERE EditorialId=@id";
                var comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombreEditorial", editorial.NombreEditorial);
                comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool EstaRelacionado(Editorial editorial)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Libros WHERE EditorialId=@id";
                var comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", editorial.EditorialId);
                int cantidadRegistros = (int)comando.ExecuteScalar();
                if (cantidadRegistros > 0)
                {
                    return true;
                }
                return false;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Agregar(Editorial editorial)
        {
            try
            {
                string cadenaComando = "INSERT INTO Editoriales VALUES (@nombreEditorial, @paisId)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombreEditorial", editorial.NombreEditorial);
                comando.Parameters.AddWithValue("@paisId", editorial.Pais.PaisId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Editorial ConstruirEditorial(SqlDataReader reader)
        {
            //return new Editorial
            //{
            //    EditorialId = reader.GetInt32(0),
            //    NombreEditorial = reader.GetString(1),
            //    Pais = _repositorioPais.GetPaisPorId(reader.GetInt32(2)) 
            //};
            Editorial e = new Editorial();

            e.EditorialId = reader.GetInt32(0);
            e.NombreEditorial = reader.GetString(1);
            e.Pais = repositorioPaises.GetPaisPorId(reader.GetInt32(2));
            return e;
           
        }
    }
}
