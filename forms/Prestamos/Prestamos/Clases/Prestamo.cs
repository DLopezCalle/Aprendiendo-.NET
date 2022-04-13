using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Clases
{
    public class Prestamo
    {
        // ========== Atributos ==========
        private int _id;
        private Amigo _amigo;
        private Libro _libro;
        private bool _devuelto = false;


        // ========== Getters y Setters ==========
        public int Id { get => _id; set => _id = value; }
        public Amigo Amigo { get => _amigo; set => _amigo = value; }
        public Libro Libro { get => _libro; set => _libro = value; }
        public bool Devuelto { get => _devuelto; set => _devuelto = value; }

        // ========== Constructores ==========
        public Prestamo()
        {
        }
        public Prestamo(int id, Amigo amigo, Libro libro, bool devuelto)
        {
            _id = id;
            _amigo = amigo;
            _libro = libro;
            _devuelto = devuelto;
        }
        public Prestamo(Amigo amigo, Libro libro)
        {
            _amigo = amigo;
            _libro = libro;
        }

        public override string ToString()
        {
            string s;
            if (_devuelto == false)
                s = "no ha sido devuelto";
            else
                s = "no ha sido devuelto";

            return $"{_libro.Titulo} ha sido prestado a {_amigo.Nombre}, {s}";
        }
    }
}
