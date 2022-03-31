using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Vehiculo
    {
        protected int _ruedas;
        protected string _color;

        public Vehiculo()
        {
            _ruedas = 4;
            _color = "Negro";
        }

        public Vehiculo(int ruedas, string color)
        {
            _ruedas = ruedas;
            _color = color;
        }

        public int Ruedas { get => _ruedas; set => _ruedas = value; }
        public string Color { get => _color; set => _color = value; }

        public virtual void Circular()
        {
            Console.WriteLine("Vehículo circulando...");
        }
    }
}
