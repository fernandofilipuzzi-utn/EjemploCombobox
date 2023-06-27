using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploCombobox
{
    class RegistroConducir
    {
        public string Nombre { get; set; }
        public string Categoria { get; set; }

        public int Puntos { get; set; }

        public RegistroConducir(string nombre, string categoria)
        {
            this.Nombre = nombre;
            this.Categoria = categoria;
            Puntos = 0;
        }
    }
}
