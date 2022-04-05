using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones3
{
    internal class Documento
    {
        private int _hojas;

        public Documento()
        {
        }

        public Documento(int folios)
        {
            _hojas = folios;
        }

        public int Folios { get => _hojas; set => _hojas = value; }

        public void ImprimirDocumento(Impresora impresora)
        {
            if (impresora.Tinta < _hojas * 5)
                throw new ExcepcionTinta();
            else
                impresora.Tinta = impresora.Tinta - (this._hojas * 5);
            if (impresora.Folios < _hojas)
                throw new ExcepcionHoja();
            else
                impresora.Folios = impresora.Folios - this._hojas;
        }
    }
}
