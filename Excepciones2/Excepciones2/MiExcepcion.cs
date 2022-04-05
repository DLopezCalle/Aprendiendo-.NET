using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones2
{
    internal class MiExcepcion : Exception
    {
        private int _codigo;

        public MiExcepcion(int codigo, string message) : base(message)
        {
            this._codigo = codigo;
        }

        public override string ToString()
        {
            return $"ERROR {_codigo}: {Message}...";
        }
    }
}
