using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar.Clases
{
    public class Articulo
    {
        // ========== Atributos ==========
        private int _id;
        private int _idCategoria;
        private string _descripcion;
        private double _precio;

        // ========== Getters y Setters ==========
        public int Id { get => _id; set => _id = value; }
        public int IdCategoria { get => _idCategoria; set => _idCategoria = value; }
        public string Descripcion { get => _descripcion; set => _descripcion = value; }
        public double Precio { get => _precio; set => _precio = value; }

        // ========== Constructores ============
        public Articulo()
        {}
        public Articulo(int id, int idCategoria, string descripcion, double precio)
        {
            _id = id;
            _idCategoria = idCategoria;
            _descripcion = descripcion;
            _precio = precio;
        }
        public Articulo(int idCategoria, string descripcion, double precio)
        {
            _idCategoria = idCategoria;
            _descripcion = descripcion;
            _precio = precio;
        }
    }
}
