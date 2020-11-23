using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioTipoDeDocumentos
    {

        private RepositorioTiposDeDocumentos repositorio;
        private ConexionBd _conexion;
        public ServicioTipoDeDocumentos()
        {

        }
        public List<TipoDeDocumento> GetTipoDeDoc()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                var lista = repositorio.GetProvincias();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Agregar(TipoDeDocumento tipoDeDocumento)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                repositorio.Agregar(tipoDeDocumento);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                var existe = repositorio.Existe(tipoDeDocumento);
                _conexion.CerrarConexion();
                return existe;
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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                repositorio.Borrar(TipoDeDocId);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioTiposDeDocumentos(_conexion.AbrirConexion());
                repositorio.Editar(tipoDeDocumento);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
