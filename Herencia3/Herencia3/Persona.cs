using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia3
{
    internal class Persona
    {
        private string _nombre;
        private int _edad;

        protected string Nombre { get => _nombre; set => _nombre = value; }
        protected int Edad { get => _edad; set => _edad = value; }

        public Persona()
        {
        }

        public Persona(string nombre, int edad)
        {
            _nombre = nombre;
            _edad = edad;
        }

        public virtual void Imprimir()
        { 
            Console.Write($"Soy { _nombre} y tengo { _edad}");
        }

        public virtual Empleado Envidia(Empleado e1)
        {
            return e1;
        }
    }
}
