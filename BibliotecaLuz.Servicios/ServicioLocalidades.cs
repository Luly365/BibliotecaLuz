using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioLocalidades
    {
        private ConexionBd conexionBd;
        private RepositorioLocalidades repositorio;
        private RepositorioProvincias repositorioProvincias;
       
        public ServicioLocalidades()
        {

        }

        public void Borrar(Localidad localidad)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexionBd.AbrirConexion());
                repositorio.Borrar(localidad);
                conexionBd.CerrarConexion();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }


        public List<Localidad> GetLocalidad()
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorioProvincias = new RepositorioProvincias(conexionBd.AbrirConexion());
                repositorio = new RepositorioLocalidades(conexionBd.AbrirConexion(), repositorioProvincias);
                var lista = repositorio.GetLocalidades();
                conexionBd.CerrarConexion();
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
                conexionBd = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexionBd.AbrirConexion());
                var existe = repositorio.Existe(localidad);
                conexionBd.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Agregar(Localidad localidad)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexionBd.AbrirConexion());
                repositorio.Agregar(localidad);
                conexionBd.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public bool EstaRelacionado(Localidad localidad)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexionBd.AbrirConexion());
                var relacionado = repositorio.EstaRelacionado(localidad);
                conexionBd.CerrarConexion();
                return relacionado;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Editar(Localidad localidad)
        {
            try
            {
                conexionBd = new ConexionBd();
                repositorio = new RepositorioLocalidades(conexionBd.AbrirConexion());
                repositorio.Editar(localidad);
                conexionBd.CerrarConexion();
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
