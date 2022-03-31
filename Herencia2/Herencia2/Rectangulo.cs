using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia2
{
    internal class Rectangulo:Figura
    {
        private int alto;
        private int ancho;

        public Rectangulo()
        {
            this.alto = 0;
            this.ancho = 0;
        }

        public Rectangulo(string color, int alto, int ancho)
        {
            _color = color;
            this.alto = alto;
            this.ancho = ancho;
        }

        public int Alto { get => alto; set => alto = value; }
        public int Ancho { get => ancho; set => ancho = value; }

        public override int Perimetro()
        {
            int result = (alto * 2) + (ancho * 2);
            return result;
        }
    }
}
