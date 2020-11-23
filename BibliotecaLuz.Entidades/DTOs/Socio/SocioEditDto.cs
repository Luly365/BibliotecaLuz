using BibliotecaLuz.Entidades.DTOs.Localidad;
using BibliotecaLuz.Entidades.DTOs.Provincia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Entidades.DTOs.Socio
{
    public class SocioEditDto
    {
        public int SocioId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public TipoDeDocDto TipoDeDocDto { get; set; }
        public string NroDoc { get; set; }
        public string Direccion { get; set; }
        public LocalidadListDto LocalidadListDto { get; set; }
        public ProvinciaListDto ProvinciaListDto { get; set; }
        public DateTime FechaNac { get; set; }
        public string TelefonoFijo { get; set; }
        public string TelefonoMovil { get; set; }
        public string CorreoElectronico { get; set; }
        public bool Sancionado { get; set; }
        public bool Activo { get; set; }

    }
}
