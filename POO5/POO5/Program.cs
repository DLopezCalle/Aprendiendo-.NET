using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    internal class Program
    {
        static int Leer(string mensaje)
        {
            string linea;
            Console.Write(mensaje);
            linea = Console.ReadLine();
            return int.Parse(linea);
        }
        static void Main(string[] args)
        {
            int num1 = 0;
            int num2 = 0;

            num1 = Leer("Ingrese el primer operando: ");
            num2 = Leer("Ingrese el segundo operando: ");

            Operacion operacion = new Operacion(num1, num2);

            Console.WriteLine($"Suma: {operacion.Suma()}");
            Console.WriteLine($"Resta: {operacion.Resta()}");
            Console.WriteLine($"Multiplicación: {operacion.Multiplicacion()}");
            Console.WriteLine($"División: {operacion.Division()}");

            Console.ReadKey();
        }
    }
}
