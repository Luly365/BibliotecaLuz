using BibliotecaLuz.Entidades.DTOs.Localidad;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class RepositorioLocalidades
    {
        private readonly SqlConnection _conexion;
        private readonly RepositorioProvincias _repositorioProvincias;
        public RepositorioLocalidades(SqlConnection conexion, RepositorioProvincias repositorioProvincias)
        {
            _conexion = conexion;
            _repositorioProvincias = repositorioProvincias;

        }
        public RepositorioLocalidades(SqlConnection cn)
        {
            _conexion = cn;
        }

        public void Borrar(Localidad localidad)
        {
            try
            {
                string cadenaComando = "DELETE FROM Localidades WHERE LocalidadId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", localidad.LocalidadId);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public List<Localidad> GetLocalidades()
        {
               
                try
                {
                
                List<Localidad> lista = new List<Localidad>();
                string cadenaComando = "SELECT LocalidadId, NombreLocalidad, ProvinciaId FROM Localidades";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                    {
                        Localidad localidad = ConstruirLocalidad(reader);
                        lista.Add(localidad);
                    }
                    reader.Close();
                    return lista;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }
        }

        public bool Existe(Localidad localidad)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (localidad.LocalidadId == 0)
                {
                    var cadenaComando = "SELECT LocalidadId, NombreLocalidad, ProvinciaId FROM Localidades WHERE NombreLocalidad=@nombrelocalidad AND ProvinciaId=@provinciaid";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombrelocalidad", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@provinciaid",localidad.provincia.ProvinciaId);

                }
                else
                {
                    var cadenaComando = "SELECT LocalidadId, NombreLocalidad, ProvinciaId FROM Localidades WHERE NombreLocalidad=@nombrelocalidad AND ProvinciaId=@provinciaid AND LocalidadId<>@id";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@nombrelocalidad", localidad.NombreLocalidad);
                    comando.Parameters.AddWithValue("@provinciaid", localidad.provincia.ProvinciaId);
                    comando.Parameters.AddWithValue("@id", localidad.LocalidadId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public LocalidadListDto GetLocalidadesporId(int id)
        {
            {
                try
                {
                    LocalidadListDto localidadDto = null;
                    string cadenaComando = "SELECT LocalidadId, NombreLocalidad FROM Localidades WHERE LocalidadId=@id";
                    SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@id", id);
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.HasRows)
                    {
                        reader.Read();
                        localidadDto = ConstruirLocalidadDto(reader);
                        reader.Close();
                    }
                    return localidadDto;
                }
                catch (Exception e)
                {

                    throw new Exception(e.Message);
                }
            }
        }

        private LocalidadListDto ConstruirLocalidadDto(SqlDataReader reader)
        {
            return new LocalidadListDto
            {
                LocalidadId = reader.GetInt32(0),
                NombreLocalidad=reader.GetString(1)
            };
        }

        public void Editar(Localidad localidad)
        {
            try
            {
                var cadenaComando = "UPDATE Localidades SET NombreLocalidad=@nombrelocalidad WHERE LocalidadId=@id";
                var comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombrelocalidad", localidad.NombreLocalidad);
                comando.Parameters.AddWithValue("@id", localidad.LocalidadId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public bool EstaRelacionado(Localidad localidad)
        {
            try
            {
                var cadenaComando = "SELECT COUNT(*) FROM Socios WHERE LocalidadId=@id";
                var comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", localidad.LocalidadId);
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

        public void Agregar(Localidad localidad)
        {
            try
            {
                string cadenaComando = "INSERT INTO Localidades VALUES (@nombrelocalidad, @provinciaid)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@nombrelocalidad", localidad.NombreLocalidad);
                comando.Parameters.AddWithValue("@provinciaid", localidad.provincia.ProvinciaId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        private Localidad ConstruirLocalidad(SqlDataReader reader)
        {
            return new Localidad
            {
                LocalidadId = reader.GetInt32(0),
                NombreLocalidad = reader.GetString(1),
                provincia = _repositorioProvincias. GetProvinciasPorId(reader.GetInt32(2)) //si descomento esto me carga el formulario de localidad, si esta comentado NO ANDA

            };
        }


    }
}
