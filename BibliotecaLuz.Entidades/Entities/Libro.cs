using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Entidades.Entities
{
    public class Libro
    {
        public int LibroId { get; set; }
        public string Titulo { get; set; }
        public string ISBN { get; set; }
        public string Editorial { get; set; }
        //falta genero
       
        public DateTime FechaIncorporacion { get; set; }
        
        public string Observaciones { get; set; }
        public bool Disponible { get; set; }


    }
}
