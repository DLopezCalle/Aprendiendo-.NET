using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Diego";
            persona.Altura = 1.70;
            Console.Write($"Nombre: {persona.Nombre}\n");
            Console.Write($"Altura: {persona.Altura}\n");
            Console.ReadKey();
        }
    }
}
