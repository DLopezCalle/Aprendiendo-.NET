using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito2.Clases
{
    public class Articulo
    {
        // ========== Atributos ==========
        private int _id;
        private string _descripcion;
        private double _precio;

        // ========== Getters y Setters ==========
        public int Id { get => _id; set => _id = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Precio { get => _precio; set => _precio = value; }

        // ========== Constructores ==========
        public Articulo()
        {}
        public Articulo(int id, string descripcion, double precio)
        {
            _id = id;
            _descripcion = descripcion;
            _precio = precio;
        }
        public Articulo(string descripcion, double precio)
        {
            _descripcion = descripcion;
            _precio = precio;
        }
        public override string ToString()
        {
            return $"{_id}.\t{_descripcion}...\tPrecio unitario: {_precio} euros";
        }
    }
}
