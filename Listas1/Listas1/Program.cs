using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas1
{
    internal class Program
    {
        private static bool BorrarSiCumple(int valor)
        {
            if (valor > 100)
                return true;
            return false;
        }

        private static void ImprimirLista(List<int> lista)
        {
            foreach (int num in lista)
                Console.Write(num + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            // Declaro lista
            List<int> lista = new List<int>();

            // Inserto elementos en la lista
            lista.Add(10);
            lista.Add(20);
            lista.Add(30);
            lista.Add(500);
            lista.Add(400);

            // Imprimir los elementos de la lista
            ImprimirLista(lista);

            // Inserto un elemento en la posicion de la lista
            lista.Insert(0, 100);
            lista.Insert(0, 100);
            ImprimirLista(lista);

            // Quito el primer elemento con valor 10
            lista.Remove(100);
            ImprimirLista(lista);

            // Quito el elemento 3 (empieza de 0)
            lista.RemoveAt(2);
            ImprimirLista(lista);

            // Borro todos los mayores de 100 (TREMENDO)
            lista.RemoveAll(BorrarSiCumple);
            ImprimirLista(lista);

            for (int i = 0; i < 10; i++)
                lista.Add(i);
            ImprimirLista(lista);

            // Ordena la lista de menor a mayor
            lista.Sort();
            ImprimirLista(lista);

            Console.ReadKey();
        }
    }
}
