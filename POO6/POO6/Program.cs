using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehiculo vehiculo = new Vehiculo(4, "Rojo");
            Moto moto = new Moto(2, "Rojo", false);

            string s = (moto.Carenado) ? "con carenado" : "sin carenado";
            Console.WriteLine($"Soy una moto con {moto.Ruedas} ruedas, {moto.Color.ToLower()} y {s}");

            vehiculo.Circular();
            moto.Circular();

            Vehiculo[] arr_vehiculos = new Vehiculo[2];

            arr_vehiculos[0] = new Vehiculo(4, "Amarillo");
            arr_vehiculos[1] = new Moto(2, "Negro", false);

            foreach(Vehiculo vv in arr_vehiculos)
            {
                vv.Circular();
            }

            Console.ReadKey();
        }
    }
}
