using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Figura
    {
        protected string _color;

        public Figura()
        {
        }

        public Figura(string color)
        {
            this._color = color;
        }

        public string Color { get => _color; set => _color = value; }

        public virtual int Perimetro()
        {
            return -1;
        }
    }
}
