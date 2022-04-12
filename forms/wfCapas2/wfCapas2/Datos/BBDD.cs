using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wfCapas2.Clases;

namespace wfCapas2.Datos
{
    public static class BBDD
    {
        public static List<Provincia> lista_provincias;
        public static List<Poblacion> lista_poblaciones;
        private static List<Poblacion> _lista_poblaciones;

        public static void Provincias()
        {
            lista_provincias = new List<Provincia>();

            lista_provincias.Add(new Provincia(1, "Bizkaia"));
            lista_provincias.Add(new Provincia(2, "Gipuzkoa"));
            lista_provincias.Add(new Provincia(3, "Araba"));
        }

        public static void Poblaciones()
        {
            _lista_poblaciones = new List<Poblacion>();

            _lista_poblaciones.Add(new Poblacion(1, "Bilbao", "Bizkaia"));
            _lista_poblaciones.Add(new Poblacion(2, "Durango", "Bizkaia"));
            _lista_poblaciones.Add(new Poblacion(3, "Bermeo", "Bizkaia"));

            _lista_poblaciones.Add(new Poblacion(1, "San Sebastian", "Gipuzkoa"));
            _lista_poblaciones.Add(new Poblacion(2, "Éibar", "Gipuzkoa"));
            _lista_poblaciones.Add(new Poblacion(3, "Arama", "Gipuzkoa"));

            _lista_poblaciones.Add(new Poblacion(1, "Vitoria", "Araba"));
            _lista_poblaciones.Add(new Poblacion(2, "Leza", "Araba"));
            _lista_poblaciones.Add(new Poblacion(3, "Elciego", "Araba"));
        }

        public static void Poblaciones(Provincia provincia)
        { 
            lista_poblaciones = new List<Poblacion>();
            foreach (Poblacion poblacion in _lista_poblaciones)
            {
                if (provincia.Nombre.Equals(poblacion.Provincia))
                    lista_poblaciones.Add(poblacion);
            }
        }
    }
}
