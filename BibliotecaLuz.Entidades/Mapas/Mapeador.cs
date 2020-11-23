using BibliotecaLuz.Entidades.DTOs.Localidad;
using BibliotecaLuz.Entidades.DTOs.Provincia;
using BibliotecaLuz.Entidades.DTOs.Socio;
using BibliotecaLuz.Entidades.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Entidades.Mapas
{
    public class Mapeador
    {
        public static LocalidadListDto ConvertirLocalidadListDto(Localidad localidad)
        {
            return new LocalidadListDto
            {
                LocalidadId = localidad.LocalidadId,
                NombreLocalidad = localidad.NombreLocalidad
            };
        }



        public static ProvinciaListDto ConvertirProvinciaListDto(Provincia provincia)
        {
            return new ProvinciaListDto
            {
                ProvinciaId = provincia.ProvinciaId,
                NombreProvincia = provincia.NombreProvincia
            };
        }

        public static Socio ConvertirSocio(SocioEditDto sociodto)
        {
            return new Socio
            {
                SocioId = sociodto.SocioId,
                Nombre = sociodto.Nombre,
                Apellido = sociodto.Apellido,
                NroDoc = sociodto.NroDoc,
                Direccion = sociodto.Direccion,
                Localidad = ConvertirLocalidad(sociodto.LocalidadListDto),
                FechaNac=sociodto.FechaNac,
                TelefonoFijo=sociodto.TelefonoFijo,
                TelefonoMovil=sociodto.TelefonoMovil,
                CorreoElectronico= sociodto.CorreoElectronico,
                Sancionado= sociodto.Sancionado,
                Activo= sociodto.Activo
            };
        }

        private static Localidad ConvertirLocalidad(LocalidadListDto localidadListDto)
        {
            return new Localidad
            {
                LocalidadId = localidadListDto.LocalidadId,
                NombreLocalidad=localidadListDto.NombreLocalidad,

            };
        }

        public static SocioListDto ConvertirASocioDto(SocioEditDto socioEditDto)
        {
            return new SocioListDto
            {
                SocioId = socioEditDto.SocioId,
                Nombre=socioEditDto.Nombre,
                Apellido= socioEditDto.Apellido,
                NroDoc=socioEditDto.NroDoc,
                Direccion=socioEditDto.Direccion,
                LocalidadListDto=socioEditDto.LocalidadListDto,

            };
        }
    }
}
