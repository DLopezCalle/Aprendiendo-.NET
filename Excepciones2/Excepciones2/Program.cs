using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduce un número por teclado: ");
                string linea = Console.ReadLine();
                int n = int.Parse(linea);

                if (n % 2 == 0)
                    throw new MiExcepcion(10, "Número Par");
                else if (n > 1000)
                    throw new MiExcepcion(10, "Número mayor que 1000");
                else
                    Console.WriteLine($"{n}");
            }
            catch (MiExcepcion e)
            {
                Console.WriteLine(e);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
