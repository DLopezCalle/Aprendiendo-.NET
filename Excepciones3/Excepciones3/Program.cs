using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool impreso = false;

            Impresora impresora1 = new Impresora(2, 15);
            Impresora impresora2 = new Impresora(10, 10);

            Documento documento1 = new Documento(20);

            while (!impreso)
            {

                try
                {
                    documento1.Imprimir(impresora1);
                    impreso = true;
                    Console.WriteLine("Operación realizada");
                }
                catch (ExcepcionTinta e)
                {
                    Console.WriteLine(e);
                    impresora1.Tinta += documento1.Hojas * 5;
                    Console.WriteLine("Tinta recargada");

                }
                catch (ExcepcionHoja e)
                {
                    Console.WriteLine(e);
                    impresora1.Folios += documento1.Hojas;
                    Console.WriteLine("Folios recargados");
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
}
