using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    internal class Moto:Vehiculo
    {
        private bool _carenado;

        public Moto()
        {
            _carenado = false;
        }

        public Moto(int ruedas, string color, bool carenado)
        {
            _ruedas = ruedas;
            _color = color;
            _carenado = carenado;
        }

        public bool Carenado { get => _carenado; set => _carenado = value; }

        public override void Circular()
        {
            Console.WriteLine("... Moto circulando");
        }
    }
}
