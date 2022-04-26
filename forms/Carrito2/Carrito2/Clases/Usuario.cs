using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carrito2.Clases
{
    public class Usuario
    {
        // ========== Atributos ==========
        private int _id;
        private string _nombre;
        private string _pass;

        // ========== Getters y Setters ==========
        public int Id { get => _id; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Pass { get => _pass; set => _pass = value; }

        // ========= Constructor ==========
        public Usuario()
        {}
        public Usuario(int id, string nombre, string pass)
        {
            _id = id;
            _nombre = nombre;
            _pass = pass;
        }
        public Usuario(string nombre, string pass)
        {
            _nombre = nombre;
            _pass = pass;
        }
        public override string ToString()
        {
            return $"{_id}.\t{_nombre}";
        }
    }
}
