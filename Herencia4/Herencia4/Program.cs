using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona("Diego", 21);
            Persona persona2 = new Persona("Diego", 21);

            Console.WriteLine(persona.ToString());

            if (persona.Equals(persona2))
                Console.WriteLine("Son iguales");
            else
                Console.WriteLine("NO son iguales");

            Console.ReadKey();
        }
    }
}
