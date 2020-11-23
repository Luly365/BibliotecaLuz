using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioProvincias 
    {
       
        private RepositorioProvincias repositorio;
        private ConexionBd _conexion;
        public ServicioProvincias()
        {
            
        }

        public List<Provincia> GetProvincias()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(_conexion.AbrirConexion());
                var lista = repositorio.GetProvincias();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Agregar(Provincia provincia)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(_conexion.AbrirConexion());
                repositorio.Agregar(provincia);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Provincia provincia)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(_conexion.AbrirConexion());
                var existe = repositorio.Existe(provincia);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int provinciaId)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(_conexion.AbrirConexion());
                repositorio.Borrar(provinciaId);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Editar(Provincia provincia)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioProvincias(_conexion.AbrirConexion());
                repositorio.Editar(provincia);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
