using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfTextBox
{
    internal class NoHayOperandoException : Exception
    {
        public NoHayOperandoException(string message) : base(message)
        {
        }
    }
}
