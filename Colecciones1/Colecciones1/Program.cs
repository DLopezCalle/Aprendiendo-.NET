using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Definir la pila
            Stack<int> pila = new Stack<int>();

            // Insertar elementos en la pila
            pila.Push(10);
            pila.Push(20);
            pila.Push(75);

            // Recorrer la pila
            while (pila.Count > 0)
            {
                Console.WriteLine(pila.Pop());
                Console.WriteLine($"Tamaño de la Pila: {pila.Count}");
            }

            // Definir la cola
            Queue<string> cola = new Queue<string>();

            // Insertar elementos en la cola
            cola.Enqueue("Manolo");
            cola.Enqueue("Diego");
            cola.Enqueue("Carlos");

            // Recorrer la cola
            while (cola.Count > 0)
            {
                Console.WriteLine(cola.Dequeue());
                Console.WriteLine($"Tamaño de la Cola: {cola.Count}");
            }

            Console.ReadKey();
        }
    }
}
