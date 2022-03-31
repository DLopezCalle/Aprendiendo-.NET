using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia4
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

        public override string ToString()
        {
            return $"Soy { _nombre} y tengo { _edad}";
        }

        public override bool Equals(object obj)
        {
            if (obj is Persona)
            {
                Persona persona = (Persona)obj;
                if (persona.Edad == this._edad && persona.Nombre.Equals(this._nombre))
                    return true;
            }                
            return false;
        }
    }
}
