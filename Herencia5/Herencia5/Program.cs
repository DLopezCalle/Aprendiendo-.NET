using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            double totalIVA = 0;
            int counter = 0;
            Factura[] lista = new Factura[6];

            lista[0] = new Factura(7, 11);
            lista[1] = new FacturaIVA(1, 11, 8);
            lista[2] = new Factura(2, 11);
            lista[3] = new Factura(3, 11);
            lista[4] = new Factura(4, 11);
            lista[5] = new Factura(5, 11);

            foreach (Factura factura in lista)
            {
                if (factura is FacturaIVA)
                {
                    totalIVA = totalIVA + factura.getTotal();
                    counter++;
                }
                else
                    total = total + factura.getTotal();
            }

            if (counter <= lista.Length / 2)
                Console.WriteLine("LEGAL");                
            else
                Console.WriteLine("PUTO PIRATA");

            Console.WriteLine($"Total con IVA: {totalIVA}");
            Console.WriteLine($"Total sin IVA: {total}");

            Console.ReadKey();
        }
    }
}
