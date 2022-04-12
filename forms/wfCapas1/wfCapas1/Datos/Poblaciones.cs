using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfCapas1.Clases;

namespace wfCapas1.Datos
{
    public static class Poblaciones
    {
        private static List<Poblacion> _poblaciones = null;

        public static List<Poblacion> ListaPoblaciones { get => _poblaciones; }
        public static void CargarPoblacion()
        {
            _poblaciones = new List<Poblacion>();

            _poblaciones.Add(new Poblacion("48370", "Bermeo"));
            _poblaciones.Add(new Poblacion("48200", "Durango"));
            _poblaciones.Add(new Poblacion("48201", "Otxandio"));
            _poblaciones .Add(new Poblacion("48901", "Barakaldo"));
        }
    }
}
