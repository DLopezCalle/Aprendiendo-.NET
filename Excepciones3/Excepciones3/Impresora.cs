using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones3
{
    internal class Impresora
    {
        private int _tinta;
        private int _folios;

        public Impresora()
        {
        }

        public Impresora(int tinta, int folios)
        {
            _tinta = tinta;
            _folios = folios;
        }

        public int Tinta { get => _tinta; set => _tinta = value; }
        public int Folios { get => _folios; set => _folios = value; }

        /*
        public void CargarTinta(int tinta)
        {
            _tinta += tinta;
        }

        public void CargarFolios(int folios)
        {
            _folios += folios;
        }
        */
        /*
        public void ImprimirDocumento(Documento documento)
        {
            if (this._tinta < documento.Hojas * 5)
                throw new ExcepcionTinta();
            else
                this._tinta -= (documento.Hojas * 5);
            if (this._folios < documento.Hojas)
                throw new ExcepcionHoja();
            else
                this._folios -= documento.Hojas;
        }
        */
    }
}
