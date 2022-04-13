using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prestamos.Clases
{
    public class Amigo
    {
        // ========== Atributos ==========
        private int _id;
        private string _nombre;
        private string _email;

        // ========== Getters y Setter ==========
        public int Id { get => _id; set => _id = value; }
        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Email { get => _email; set => _email = value; }

        // ========== Constructores ==========
        public Amigo()
        {
        }
        public Amigo(int id, string nombre, string email)
        {
            _id = id;
            _nombre = nombre;
            _email = email;
        }
        public Amigo(string nombre, string email)
        {
            _id = 0;
            _nombre = nombre;
            _email = email;
        }

        public override string ToString()
        {
            return $"{_nombre}, email:\t{_email}";
        }
    }
}
