using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrix
{
    internal class Program
    {
        static void Leer(int[,] arr)
        {
            string linea;
            for(int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Introduzca el valor de coordenadas ({i + 1}, {j + 1}): ");
                    linea = Console.ReadLine();
                    arr[i, j] = int.Parse(linea);
                }
            }
        }

        static void Escribir(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"La coordenada ({i + 1}, {j + 1}) es: {arr[i, j]}\n");
                }
            }
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            int[,] arr_numbers = new int[3, 5];
            Leer(arr_numbers);
            Escribir(arr_numbers);
            Console.ReadKey();
        }
    }
}
