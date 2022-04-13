using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Clases
{
    public class Libro
    {
        // ========== Atributos ==========
        private int _id;
        private string _titulo;

        // ========== Getters y Setters
        public int Id { get => _id; }
        public string Titulo { get => _titulo; set => _titulo = value; }

        public Libro()
        {
        }
        public Libro(int id, string titulo)
        {
            _id = id;
            _titulo = titulo;
        }
        public Libro(string titulo)
        {
            _titulo = titulo;
        }

        public override string ToString()
        {
            return _titulo;
        }
    }
}
