using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO4
{
    internal class Clase
    {
        private Alumno[] _lista_alumnos;

        public Clase()
        {
            this._lista_alumnos = new Alumno[3];
            this._lista_alumnos[0] = new Alumno("Diego", 21);
            this._lista_alumnos[1] = new Alumno("Pepe", 17);
            this._lista_alumnos[2] = new Alumno("Paco", 56);
        }

        public void ListaAlumnos()
        {
            Console.WriteLine("Listado de alumnos del Aula");
            for (int i = 0; i < this._lista_alumnos.Length; i++)
            {
                _lista_alumnos[i].Saludar();
            }
        }

        public void ListaAlumnos(bool mayores)
        {
            if (mayores == true)
                Console.WriteLine("Listado de alumnos del Aula mayores de edad");
            else
                Console.WriteLine("Listado de alumnos del Aula menores de edad");
            foreach (Alumno alumno in this._lista_alumnos)
            {
                if (mayores == alumno.esMayor())
                    alumno.Saludar();
            }
        }
    }
}
