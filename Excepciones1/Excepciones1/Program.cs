using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Introduce un entero por teclado: ");
                string linea = Console.ReadLine();
                int n1 = int.Parse(linea);

                Console.Write("Introduce otro entero por teclado: ");
                linea = Console.ReadLine();
                int n2 = int.Parse(linea);

                Console.WriteLine($"{n1} / {n2} = {n1 / n2}");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
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
