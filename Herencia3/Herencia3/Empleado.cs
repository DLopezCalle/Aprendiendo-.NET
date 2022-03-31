using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Empleado : Persona
    {
        private double _sueldo;

        public Empleado()
        {
        }

        public Empleado(string nombre, int edad, double salario) : base(nombre, edad)
        {
            this._sueldo = salario;
        }

        public double Sueldo { get => _sueldo; set => _sueldo = value; }

        public override void Imprimir()
        {
            Console.WriteLine();
            base.Imprimir();
            Console.WriteLine($", mi sueldo es {_sueldo}");
        }

        public override Empleado Envidia(Empleado e1)
        {
            if (this._sueldo >= e1.Sueldo)
                return this;
            return e1;
        }
    }
}
