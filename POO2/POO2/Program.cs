using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            double max_altura = 0;
            int j = 0;
            Persona[] arr_personas = new Persona[4];
            for (int i = 0; i < arr_personas.Length; i++)
            {
                Console.Write($"Introduzca el nombre de la persona: ");
                linea = Console.ReadLine();
                if (linea != null)
                    arr_personas[i].Nombre = linea;

                Console.Write($"Introduzca la altura de la persona: ");
                linea = Console.ReadLine();
                if (linea != null)
                    arr_personas[i].Altura = double.Parse(linea);

                if (arr_personas[i].Altura > max_altura)
                {
                    i = j;
                    max_altura = arr_personas[i].Altura;
                }
            }
            arr_personas[j].Saludar();
        }
    }
}
