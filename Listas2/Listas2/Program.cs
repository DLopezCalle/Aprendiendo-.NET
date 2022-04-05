using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas2
{
    internal class Program
    {
        private static void Imprimir (List<Persona> lista_personas)
        {
            foreach(Persona persona in lista_personas)
                Console.WriteLine(persona.ToString());
        }

        static void Main(string[] args)
        {
            // Creo mi lista de personas
            List<Persona> lista_personas = new List<Persona>();
            lista_personas.Add(new Persona("Diego", 21));
            lista_personas.Add(new Persona("Pepe", 14));
            lista_personas.Add(new Persona("Manolo", 52));
            lista_personas.Add(new Persona("Enrique", 45));

            // Imprimo todas las personas de la lista
            Imprimir (lista_personas);

            // Ordeno mi lista de personas por edad
            lista_personas.Sort();
            Imprimir (lista_personas);

            Console.ReadKey();
        }
    }
}
