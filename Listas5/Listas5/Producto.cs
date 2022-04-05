using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas5
{
    internal class Producto
    {
        private int _codigo;
        private string _descripcion;
        private double _precio;

        public Producto()
        {
        }

        public Producto(int codigo, string descripcion, double precio)
        {
            _codigo = codigo;
            _descripcion = descripcion;
            _precio = precio;
        }

        public int Codigo { get => _codigo; set => _codigo = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Precio { get => _precio; set => _precio = value; }
    }
}
