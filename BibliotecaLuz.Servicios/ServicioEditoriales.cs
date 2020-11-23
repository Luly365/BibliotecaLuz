using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioEditoriales
    {
        private ConexionBd conexionBd;
        private RepositorioEditoriales repositorio;
        private RepositorioPaises repositorioPais;

        public ServicioEditoriales()
        {

        }

        public void Borrar(Editorial editorial)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioEditoriales(conexionBd.AbrirConexion());
                repositorio.Borrar(editorial);
                conexionBd.CerrarConexion();
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
                conexionBd = new ConexionBd();
                repositorioPais = new RepositorioPaises(conexionBd.AbrirConexion());
                repositorio = new RepositorioEditoriales(conexionBd.AbrirConexion(), repositorioPais);
                var lista = repositorio.GetEditorial();
                conexionBd.CerrarConexion();
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
                conexionBd = new ConexionBd();
                repositorio = new RepositorioEditoriales(conexionBd.AbrirConexion());
                var existe = repositorio.Existe(editorial);
                conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Agregar(Editorial editorial)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioEditoriales(conexionBd.AbrirConexion());
                repositorio.Agregar(editorial);
                conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelaciona(Editorial editorial)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioEditoriales(conexionBd.AbrirConexion());
                var relaciona = repositorio.EstaRelacionado(editorial);
                conexionBd.CerrarConexion();
                return relaciona;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Editar(Editorial editorial)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioEditoriales(conexionBd.AbrirConexion());
                repositorio.Editar(editorial);
                conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

    }
}
