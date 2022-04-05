using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones3
{
    internal class ExcepcionTinta : Exception
    {
        public ExcepcionTinta()
        {
        }

        public override string ToString()
        {
            return "ERROR: No hay suficiente tinta";
        }
    }
}
