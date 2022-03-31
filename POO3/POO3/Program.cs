using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Diego", 1.70);
            persona.Saludar();
            persona.Nombre = "Pepe";
            Console.WriteLine(persona.Nombre);
            Console.ReadKey();
        }
    }
}
