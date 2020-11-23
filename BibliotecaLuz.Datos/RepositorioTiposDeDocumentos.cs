using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Datos
{
    public class RepositorioTiposDeDocumentos
    {
        private readonly SqlConnection _conexion;
        public RepositorioTiposDeDocumentos(SqlConnection conexion)
        {
            _conexion = conexion;
        }
        public List<TipoDeDocumento> GetProvincias()
        {
            List<TipoDeDocumento> lista = new List<TipoDeDocumento>();
            try
            {

                string cadenaComando = "SELECT TipoDeDocId, Descripcion FROM TiposDeDocumentos";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                SqlDataReader reader = comando.ExecuteReader();
                while (reader.Read())
                {

                    TipoDeDocumento tipoDeDocumento = ConstruirTipoDeDoc(reader);
                    lista.Add(tipoDeDocumento);
                }
                reader.Close();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        private TipoDeDocumento ConstruirTipoDeDoc(SqlDataReader reader)
        {
            return new TipoDeDocumento
            {
                TipoDeDocId = reader.GetInt32(0),
                Descripcion = reader.GetString(1)
            };
        }

        public void Agregar(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                var cadenaComando = "INSERT INTO TiposDeDocumentos VALUES (@Descripcion)";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@Descripcion", tipoDeDocumento.Descripcion);
                comando.ExecuteNonQuery();
                cadenaComando = "SELECT @@IDENTITY";
                comando = new SqlCommand(cadenaComando, _conexion);

                tipoDeDocumento.TipoDeDocId = (int)(decimal)comando.ExecuteScalar();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public TipoDeDocumento GetTipoDeDocPorId(int id)
        {
            try
            {
                TipoDeDocumento tipoDeDoc = null;
                string cadenaComando = "select TipoDeDocId, Descripcion from TiposDeDocumentos WHERE TipoDeDocId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", id);
                SqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    tipoDeDoc = ConstruirTipoDeDoc(reader);
                    reader.Close();
                }
                return tipoDeDoc;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }


        public bool Existe(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                SqlCommand comando = null;
                SqlDataReader reader = null;

                if (tipoDeDocumento.TipoDeDocId == 0)
                {
                    var cadenaComando = "SELECT TipoDeDocId, Descripcion FROM TiposDeDocumentos WHERE Descripcion=@descripcion";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@descripcion", tipoDeDocumento.Descripcion);

                }
                else
                {
                    var cadenaComando = "SELECT TipoDeDocId, Descripcion FROM TiposDeDocumentos WHERE Descripcion=@descripcion AND TipoDeDocId<>@id";
                    comando = new SqlCommand(cadenaComando, _conexion);
                    comando.Parameters.AddWithValue("@descripcion", tipoDeDocumento.Descripcion);
                    comando.Parameters.AddWithValue("@id", tipoDeDocumento.TipoDeDocId);
                }

                reader = comando.ExecuteReader();
                return reader.HasRows;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int TipoDeDocId)
        {
            try
            {
                string cadenaComando = "DELETE FROM TiposDeDocumentos WHERE TipoDeDocId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@id", TipoDeDocId);
                comando.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void Editar(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                string cadenaComando = "UPDATE TiposDeDocumentos SET Descripcion=@descripcion WHERE TipoDeDocId=@id";
                SqlCommand comando = new SqlCommand(cadenaComando, _conexion);
                comando.Parameters.AddWithValue("@descripcion", tipoDeDocumento.Descripcion);
                comando.Parameters.AddWithValue("@id", tipoDeDocumento.TipoDeDocId);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }

}
