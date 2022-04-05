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
            try
            {
                Impresora impresora1 = new Impresora(20, 3);
                Impresora impresora2 = new Impresora(10, 10);

                Documento documento1 = new Documento(5);

                documento1.ImprimirDocumento(impresora1);

                Console.WriteLine("Operación realizada");
            }
            catch (ExcepcionTinta e)
            {
                Console.WriteLine(e);
            }
            catch (ExcepcionHoja e)
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
