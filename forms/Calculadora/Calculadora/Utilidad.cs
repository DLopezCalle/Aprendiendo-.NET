using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    internal static class Utilidad
    {
        public static int n1 = 0;
        public static int n2 = 0;
        public static string operador = "";

        public static int Sumar ()
        {
            return Utilidad.n1 + Utilidad.n2;
        }

        public static int Restar ()
        {
            return Utilidad.n1 - Utilidad.n2;
        }

        public static int Multiplicar ()
        {
            return Utilidad.n1 * Utilidad.n2;
        }

        public static int Dividir ()
        {
            return Utilidad.n1 / Utilidad.n2;
        }

        public static int Resto ()
        {
            return Utilidad.n1 % Utilidad.n2;
        }

        public static void Resetear()
        {
            operador = "";
            n1 = 0;
            n2 = 0;
        }
    }
}
