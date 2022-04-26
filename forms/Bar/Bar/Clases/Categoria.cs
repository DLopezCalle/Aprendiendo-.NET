using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bar.Clases
{
    public class Categoria
    {
        // ========== Atributos ==========
        private int _id;
        private string _nombre;

        // ========== Getters y Setters ==========
        public int Id { get => _id; }
        public string Nombre { get => _nombre; set => _nombre = value; }

        // ========== Constructor ==========
        public Categoria()
        {}
        public Categoria(int id, string nombre)
        {
            _id = id;
            _nombre = nombre;
        }
        public Categoria(string nombre)
        {
            _nombre = nombre;
        }
    }
}
