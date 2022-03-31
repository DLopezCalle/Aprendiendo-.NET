using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Persona
    {
        // Atributos
        private string _nombre;
        private double _altura;

        public Persona()
        {
            _nombre = "Sin nombre";
        }

        /// <summary>
        /// Constructor con parámetros
        /// </summary>
        /// <param name="nombre">Nombre de la persona</param>
        /// <param name="altura">Altura de la persona</param>
        public Persona(string nombre, double altura)
        {
            _nombre = nombre;
            _altura = altura;
        }

        // Getters y Setters
        public string Nombre { get => _nombre; set => _nombre = value; }
        public double Altura { get => _altura; set => _altura = value; }



        // Métodos


        /// <summary>
        /// Visualiza por consola los datos de un usuario
        /// </summary>
        public void Saludar()
        {
            Console.WriteLine($"Hola, soy {_nombre} y mi altura es {_altura}");
        }
    }
}
