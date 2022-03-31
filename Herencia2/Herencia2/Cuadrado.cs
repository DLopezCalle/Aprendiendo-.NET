using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Cuadrado:Figura
    {
        private int _lado;

        public Cuadrado()
        {
            this._lado = 0;
        }

        public Cuadrado(string color, int lado)
        {
            _color = color;
            this._lado = lado;
        }

        public int Lado { get => _lado; set => _lado = value; }

        public override int Perimetro()
        {
            return _lado * 4;
        }
    }
}
