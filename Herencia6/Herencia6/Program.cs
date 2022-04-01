using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta[] lista_cuentas = new Cuenta[5];
            lista_cuentas[0] = new CuentaRegular("Diego", "Calle1", 1200);
            lista_cuentas[1] = new CuentaRegular("Pepe", 1200);
            lista_cuentas[2] = new CuentaDorada("Pepa", "Calle3", 1200);
            lista_cuentas[3] = new CuentaRegular("Paco", "Calle4", 1200);
            lista_cuentas[4] = new CuentaDorada("Carla", 1200);

            lista_cuentas[0].Depositar(100);
            lista_cuentas[0].Retirar(1300.1);

            lista_cuentas[4].Depositar(100);
            lista_cuentas[4].Retirar(300);

            foreach (Cuenta cuenta in lista_cuentas)
            {
                Console.WriteLine(cuenta.ToString());
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
