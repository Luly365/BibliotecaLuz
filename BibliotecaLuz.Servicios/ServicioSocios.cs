using BibliotecaLuz.Datos;
using BibliotecaLuz.Entidades.DTOs.Socio;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Servicios
{
    public class ServicioSocios 
    {
        private RepositorioSocios _repositorioSocios;
        private RepositorioLocalidades _repositorioLocalidades;
        
        private RepositorioProvincias _repositorioProvincias;
        //private RepositorioTiposDeDocumentos _repositorioTiposDeDocumentos;
        private ConexionBd _conexion;


        public ServicioSocios()
        {

        }

     
        public List<SocioListDto> GetLista()
        {
            try
            {
                _conexion = new ConexionBd();
                _repositorioLocalidades = new RepositorioLocalidades(_conexion.AbrirConexion());
                _repositorioSocios = new RepositorioSocios(_conexion.AbrirConexion(), _repositorioLocalidades, _repositorioProvincias);
                var lista = _repositorioSocios.GetLista();
                _conexion.CerrarConexion();
                return lista;

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }

        }

        //public bool Existe(SocioListDto socioListDto)
        //{

        //    try
        //    {
        //        _conexion = new ConexionBd();
        //        _repositorioSocios = new RepositorioSocios(_conexion.AbrirConexion(), _repositorioLocalidades);
        //        var existe = _repositorioSocios.Existe(socioListDto);//socioListDto
        //        _conexion.CerrarConexion();
        //        return (bool)existe;// daba error lo tuve que castear a bool 
        //    }
        //    catch (Exception e)
        //    {

        //        Console.WriteLine(e);
        //                throw;
        //    }
        //}

        public void Agregar(SocioEditDto sociodto)
        {
            SqlTransaction tran = null;
            try
            {
                _conexion = new ConexionBd();
                _repositorioSocios = new RepositorioSocios(_conexion.AbrirConexion(), _repositorioLocalidades, _repositorioProvincias);
                _repositorioSocios.Agregar(sociodto, tran);
                _conexion.CerrarConexion();

            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
