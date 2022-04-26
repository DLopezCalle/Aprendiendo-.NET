using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito2.Clases
{
    public class Carrito
    {
        // =========== Atributos ==========
        private int _id;
        private Articulo _articulo;
        private int _cantidad;

        // ========== Getters y Setters ==========
        public int Id { get => _id; set => _id = value; }
        public Articulo Articulo { get => _articulo; set => _articulo = value; }
        public int Cantidad { get => _cantidad; set => _cantidad = value; }

        // ========== Constructores ==========
        public Carrito()
        {}
        public Carrito(int id, Articulo articulo, int cantidad)
        {
            _id = id;
            _articulo = articulo;
            _cantidad = cantidad;
        }
        public Carrito(Articulo articulo, int cantidad)
        {
            _articulo = articulo;
            _cantidad = cantidad;
        }
        private double Subtotal()
        {
            return _cantidad * _articulo.Precio;
        }

        public override string ToString()
        {
            return $"{_id}.\t {_articulo.ToString()}\t Subtotal: {Subtotal()} euros";
        }
    }
}
