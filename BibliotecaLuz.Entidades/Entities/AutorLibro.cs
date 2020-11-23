using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaLuz.Entidades.Entities
{
    public class AutorLibro
    {
        public int AutorLibroId { get; set; }
        public Libro Libro { get; set; }
        public Autor Autor { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
