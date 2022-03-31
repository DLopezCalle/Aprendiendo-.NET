using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Triangulo:Figura
    {
        private int l1;
        private int l2;
        private int l3;

        public Triangulo()
        {
            this.l1 = 0;
            this.l2 = 0;
            this.l3 = 0;
        }

        public Triangulo(string color, int l1, int l2, int l3)
        {
            _color = color;
            this.l1 = l1;
            this.l2 = l2;
            this.l3 = l3;
        }

        public override int Perimetro()
        {
            return l1 + l2 + l3;
        }
    }
}
