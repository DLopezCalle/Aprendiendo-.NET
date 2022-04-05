using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas2
{
    internal class Persona : IComparable<Persona>
    {
        private string _nombre;
        private int _edad;

        public Persona()
        {
        }

        public Persona(string nombre, int edad)
        {
            this._nombre = nombre;
            this._edad = edad;
        }

        public string Nombre { get => _nombre; set => _nombre = value; }
        public int Edad { get => _edad; set => _edad = value; }

        public int CompareTo(Persona other)
        {
            return this._edad - other._edad;
        }

        public override string ToString()
        {
            return ($"{_nombre}, {_edad} años");
        }
    }
}
