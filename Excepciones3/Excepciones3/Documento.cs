using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones3
{
    internal class Documento : I_Imprimible
    {
        private int _hojas;

        public Documento()
        {
        }

        public Documento(int folios)
        {
            _hojas = folios;
        }

        public int Hojas { get => _hojas; set => _hojas = value; }
        
        public void Imprimir(Impresora impresora)
        {
            if (impresora.Tinta < _hojas * 5)
                throw new ExcepcionTinta();
            else if (impresora.Folios < _hojas)
                throw new ExcepcionHoja();
            else
            {
                impresora.Tinta -= this._hojas * 5;
                impresora.Folios -= this._hojas;
            }                
        }        
    }
}
