using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioAutor
    {
        private RepositorioAutores repositorio;
        private ConexionBd _conexion;

        public ServicioAutor()
        {

        }
        public List<Autor> GetAutor()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioAutores(_conexion.AbrirConexion());
                var lista = repositorio.GetAutor();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Agregar(Autor autor)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioAutores(_conexion.AbrirConexion());
                repositorio.Agregar(autor);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioAutores(_conexion.AbrirConexion());
                var existe = repositorio.Existe(autor);
                _conexion.CerrarConexion();
                return existe;
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
                _conexion = new ConexionBd();
                repositorio = new RepositorioAutores(_conexion.AbrirConexion());
                repositorio.Borrar(AutorId);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioAutores(_conexion.AbrirConexion());
                repositorio.Editar(autor);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
