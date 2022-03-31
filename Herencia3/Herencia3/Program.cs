using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado[] lista = new Empleado[5];

            lista[0] = new Empleado("Diego", 21, 56);
            lista[1] = new Empleado("Pepe", 14, 89);
            lista[2] = new Empleado("Paco", 30, 100);
            lista[3] = new Empleado("Juanito", 12, 12);
            lista[4] = new Empleado("Carla", 58, 56);

            Empleado millonario = new Empleado();

            for (int i = 0; i < lista.Length; i++)
            {
                millonario = millonario.Envidia(lista[i]);
            }

            millonario.Imprimir();

            Console.ReadKey();
        }
    }
}
