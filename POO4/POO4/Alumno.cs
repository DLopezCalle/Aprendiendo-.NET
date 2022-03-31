using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    internal class Alumno
    {
        // Atributoa
        private string _nombre;
        private int _edad;

        // Getter / Setters
        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }

        public Alumno()
        {
            _nombre = "NULL";
            _edad = 0;
        }

        public Alumno(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        /// <summary>
        /// Imprimirá en consola un saludo con los datos del alumno
        /// </summary>
        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {_nombre} y tengo {_edad} años");
        }

        /// <summary>
        /// Devolverá true si el alumno es mayor de edad, y false si no lo es
        /// </summary>
            public bool esMayor()
        {
            if (_edad >= 18)
                return true;
            else
                return false;
        }
    }
}
