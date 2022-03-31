using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO5
{
    internal class Operacion
    {
        private int _num1;
        private int _num2;

        public Operacion()
        {
            _num1 = 0;
            _num2 = 0;
        }

        public Operacion(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        public int Num1 { get => _num1; set => _num1 = value; }
        public int Num2 { get => _num2; set => _num2 = value; }

        public int Suma()
        {
            int result = 0;

            result = _num1 + _num2;
            return result;
        }

        public int Resta()
        {
            int result = 0;

            result = _num1 - _num2;
            return result;
        }

        public int Multiplicacion()
        {
            int result = 0;

            result = _num1 * _num2;
            return result;
        }

        public int Division()
        {
            int result = 0;

            result = _num1 / _num2;
            return result;
        }
    }
}
