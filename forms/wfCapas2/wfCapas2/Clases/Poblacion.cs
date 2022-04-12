using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfCapas2.Clases
{
    public class Poblacion
    {
        private int _id;
        private string _nombre;
        private string _provincia;

        public Poblacion(int id, string nombre, string provincia)
        {
            _id = id;
            _nombre = nombre;
            _provincia = provincia;
        }

        public int Id { get => _id; }
        public string Nombre { get => _nombre; }
        public string Provincia { get => _provincia; }
    }
}
