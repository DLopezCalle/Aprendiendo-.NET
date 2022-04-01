using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia6
{
    internal abstract class Cuenta
    {
        private string _nombre;
        private string _direccion;
        private double _saldo;
        private int _interes;

        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected string Direccion { get => _direccion; set => _direccion = value; }
        protected double Saldo { get => _saldo; set => _saldo = value; }
        protected int Interes { get => _interes; set => _interes = value; }

        public Cuenta()
        {
        }

        public Cuenta(string nombre, string direccion, double saldo)
        {
            _nombre = nombre;
            _direccion = direccion;
            _saldo = saldo;
        }

        public Cuenta(string nombre, double saldo)
        {
            _nombre = nombre;
            _saldo = saldo;
        }

        public void MostrarSaldo()
        {
            Console.WriteLine($"{_saldo}");
        }

        public bool Depositar(double ingreso)
        {
            if (ingreso > 0)
            {
                _saldo = _saldo + ingreso;
                return true;
            }
            Console.WriteLine("Error al ingresar | Buen intento");
            return false;
        }

        public bool Retirar(double retiro)
        {
            if (retiro <= _saldo)
            {
                _saldo = _saldo - retiro;
                return (true);
            }
            Console.WriteLine("Error al retirar | No tiene suficiente dinero");
            return false;
        }

        public override string ToString()
        {
            return $"Nombre: {_nombre}\nSaldo: {_saldo}\nInterés: {_interes}";
        }
    }
}
