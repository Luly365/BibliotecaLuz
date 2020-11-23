using BibliotecaLuz.Entidades.DTOs.Socio;
using BibliotecaLuz.Entidades.Entities;
using BibliotecaLuz.Entidades.Mapas;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class RepositorioSocios
    {
        private readonly SqlConnection _connection;
        private readonly RepositorioLocalidades _repositoriolocalidades;
        private readonly RepositorioProvincias _repositorioprovincias;



        public RepositorioSocios(SqlConnection connection, RepositorioLocalidades repositoriolocalidades, RepositorioProvincias repositorioprovincias)
        {
            _connection = connection;
            _repositoriolocalidades = repositoriolocalidades;
            _repositorioprovincias = repositorioprovincias;

        }

        public List<SocioListDto> GetLista()
        {
            List<SocioListDto> lista = new List<SocioListDto>();
            try
            {
                string cadenaComando =
                    "SELECT SocioId, Nombre, Apellido,NroDoc, Direccion,LocalidadId, ProvinciaId, TelefonoFijo,TelefonoMovil, CorreoElectronico, Sancionado, Activo" +
                    " FROM Socios";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {
                    SocioListDto socioDto = ConstruirAlbumListDto(reader);
                    lista.Add(socioDto);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        private SocioListDto ConstruirAlbumListDto(SqlDataReader reader)
        {
            SocioListDto socio = new SocioListDto();

            socio.SocioId = reader.GetInt32(0);
            socio.Nombre = reader.GetString(1);
            socio.Apellido = reader.GetString(2);
            socio.NroDoc = reader.GetString(3);
            socio.Direccion = reader.GetString(4);
            socio.LocalidadListDto = _repositoriolocalidades.GetLocalidadesporId(reader.GetInt32(5));
            //socio.ProvinciaListDto = _repositorioprovincias.GetProvinciasPorId(reader.GetInt32(6));
            socio.TelefonoFijo = reader[7] != DBNull.Value ? reader.GetString(7) : null;
            socio.TelefonoMovil = reader[8] != DBNull.Value ? reader.GetString(8) : null;
            socio.CorreoElectronico = reader[9] != DBNull.Value ? reader.GetString(9) : null;
            socio.Sancionado = reader.GetBoolean(10);
            socio.Activo = reader.GetBoolean(11);
            return socio;
        }

        public void Agregar(SocioEditDto sociodto, SqlTransaction transaction)
        {
            Socio socio = Mapeador.ConvertirSocio(sociodto);

            try
            {
                string cadenaComando = "INSERT INTO Socios (SocioId, Nombre, Apellido, Direccion, LocalidadId, DireccionId, TelefonoFijo, TelefonoMovil,CorreoElectronico)" +
                    " VALUES (@socioId, @nombre, @apellido, @direccion, @localidadId, @provinciaId, @telefonoFijo, @telefonoMovil, @correoElectronico)";
                SqlCommand comando = new SqlCommand(cadenaComando, _connection, transaction);
                comando.Parameters.AddWithValue("@SocioId", socio.SocioId);
                comando.Parameters.AddWithValue("@nombre", socio.Nombre);
                comando.Parameters.AddWithValue("@apellido", socio.Apellido);
                comando.Parameters.AddWithValue("@direccion", socio.Direccion);
                comando.Parameters.AddWithValue("@localidadId", socio.Localidad.LocalidadId);
                comando.Parameters.AddWithValue("@provincia", socio.Provincia.ProvinciaId);
                comando.Parameters.AddWithValue("@telefonoFijo", socio.TelefonoFijo);
                comando.Parameters.AddWithValue("@telefonoMovil", socio.TelefonoMovil);
                comando.Parameters.AddWithValue("correoelectronico", socio.CorreoElectronico);

                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@identity";
                comando = new SqlCommand(cadenaComando, _connection,transaction);
                int id = (int)(decimal)comando.ExecuteScalar();
                socio.SocioId = id;
                sociodto.SocioId = id;


            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }






        }


    }
}
