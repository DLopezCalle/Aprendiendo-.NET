using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfCapas1.Clases
{
    public class Poblacion
    {
        public string Cp { get; set; }
        public string Nombre { get; set; }

        public Poblacion(string cp, string nombre)
        {
            Cp = cp;
            Nombre = nombre;
        }
    }
}
