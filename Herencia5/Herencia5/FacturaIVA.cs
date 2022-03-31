using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia5
{
    internal class FacturaIVA : Factura
    {
        private int _iva;

        public FacturaIVA()
        { 
        }

        public FacturaIVA(int codigo, double importe, int iva) : base(codigo, importe)
        {
            _iva = iva;
        }

        public int Iva { get => _iva; set => _iva = value; }

        public override double getTotal()
        {
            double total = ((base.getTotal() * _iva) / 100) + base.getTotal();
            return total;
        }
    }
}
