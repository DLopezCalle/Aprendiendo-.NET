using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Clase clase = new Clase();
            clase.ListaAlumnos();
            clase.ListaAlumnos(false);
            Console.ReadKey();
        }
    }
}
