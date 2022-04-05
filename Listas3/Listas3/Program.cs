using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas3
{
    internal class Program
    {
        private static void Imprimir(LinkedList<int> lista)
        {
            LinkedListNode<int> recorrido = lista.First;
            while (recorrido != null)
            { 
                Console.WriteLine(recorrido.Value);
                recorrido = recorrido.Next;
            }
        }

        private static void ImprimirReves(LinkedList<int> lista)
        {
            LinkedListNode<int> recorrido = lista.Last;
            while (recorrido != null)
            {
                Console.WriteLine(recorrido.Value);
                recorrido = recorrido.Previous;
            }
        }

        static void Main(string[] args)
        {
            LinkedList<int> lista = new LinkedList<int>();
            lista.AddFirst(30);
            lista.AddFirst(20);
            lista.AddFirst(10);

            Imprimir(lista);
            ImprimirReves(lista);

            Console.ReadKey();
        }
    }
}
