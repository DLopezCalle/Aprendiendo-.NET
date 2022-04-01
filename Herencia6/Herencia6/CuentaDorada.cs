using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6
{
    internal class CuentaDorada : Cuenta
    {
        private double _cargo;
        public CuentaDorada()
        {
            Interes = 6;
            _cargo = 100;
        }

        public CuentaDorada(string nombre, string direccion, double saldo) : base(nombre, direccion, saldo)
        {
            Interes = 6;
            _cargo = 100;
        }

        public CuentaDorada(string nombre, double saldo) : base(nombre, saldo)
        {
            Interes = 6;
            _cargo = 100;
        }

        public double Cargo { get => _cargo; set => _cargo = value; }
    }
}
