using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Persona
    {
        // Atributos
        public string Nombre;
        public double Altura;

        //Métodos
        public void Saludar()
        {
            Console.Write($"Hola, soy {Nombre}, mido {Altura}");
        }
    }
}
