using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia5
{
    internal class Factura
    {
        private int _codigo;
        private double _importe;

        

        public Factura()
        {
        }

        public Factura(int codigo, double importe)
        {
            _codigo = codigo;
            _importe = importe;
        }

        protected int Codigo { get => _codigo; set => _codigo = value; }
        protected double Importe { get => _importe; set => _importe = value; }

        public virtual double getTotal()
        {
            return _importe;
        }


    }
}
