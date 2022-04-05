using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones2
{
    internal class Program
    {


        static void Main(string[] args)
        {
            Stack<char> signos = new Stack<char>();
            Console.Write("Introduzca una formula: ");
            string linea = Console.ReadLine();

            foreach (char caracter in linea)
            {
                if (caracter == '(' || caracter == '[' || caracter == '{')
                    signos.Push(caracter);
                else if ((caracter == ')' || caracter == ']' || caracter == '}') && signos.Count > 0) // Falta controlas (}
                    signos.Pop();
                else if ((caracter == ')' || caracter == ']' || caracter == '}'))
                    signos.Push('a');
            }

            if (signos.Count == 0)
                Console.WriteLine("La sintaxis es correcta");
            else
                Console.WriteLine("Error de sintaxis");

            Console.ReadKey();
        }
    }
}
