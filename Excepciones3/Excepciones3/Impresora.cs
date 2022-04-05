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
    }
}
