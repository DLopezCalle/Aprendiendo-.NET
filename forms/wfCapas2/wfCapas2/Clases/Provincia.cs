using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfCapas2.Clases
{
    public class Provincia
    {
        private int _id;
        private string _nombre;

        public Provincia(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }

        public int Id { get => _id; }
        public string Nombre { get => _nombre; }
    }
}
