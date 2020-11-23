using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioPais
    {
        private RepositorioPaises repositorio;
        private ConexionBd _conexion;
        public ServicioPais()
        {

        }

        public List<Pais> GetPais()
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioPaises(_conexion.AbrirConexion());
                var lista = repositorio.GetPais();
                _conexion.CerrarConexion();
                return lista;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public void Agregar(Pais pais)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioPaises(_conexion.AbrirConexion());
                repositorio.Agregar(pais);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public bool Existe(Pais pais)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioPaises(_conexion.AbrirConexion());
                var existe = repositorio.Existe(pais);
                _conexion.CerrarConexion();
                return existe;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Borrar(int PaisId)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioPaises(_conexion.AbrirConexion());
                repositorio.Borrar(PaisId);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public void Editar(Pais pais)
        {
            try
            {
                _conexion = new ConexionBd();
                repositorio = new RepositorioPaises(_conexion.AbrirConexion());
                repositorio.Editar(pais);
                _conexion.CerrarConexion();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
