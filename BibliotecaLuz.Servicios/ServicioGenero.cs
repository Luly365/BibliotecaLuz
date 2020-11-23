using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioGenero
    {
        private RepositorioGeneros repositorio;
        private ConexionBd _conexion;
        public ServicioGenero()
        {

        }

        public List<Genero> GetGeneros()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioGeneros(_conexion.AbrirConexion());
                var lista = repositorio.GetGenero();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Agregar(Genero genero)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioGeneros(_conexion.AbrirConexion());
                repositorio.Agregar(genero);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioGeneros(_conexion.AbrirConexion());
                var existe = repositorio.Existe(genero);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int generoId)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioGeneros(_conexion.AbrirConexion());
                repositorio.Borrar(generoId);
                _conexion.CerrarConexion();

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
                _conexion = new ConexionBd();
                repositorio = new RepositorioGeneros(_conexion.AbrirConexion());
                repositorio.Editar(genero);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
