using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6
{
    internal class CuentaRegular : Cuenta
    {
        public CuentaRegular()
        {
            Interes = 5;
        }

        public CuentaRegular(string nombre, string direccion, double saldo) : base(nombre, direccion, saldo)
        {
            Interes = 5;
        }

        public CuentaRegular(string nombre, double saldo) : base(nombre, saldo)
        {
            Interes = 5;
        }
    }
}
