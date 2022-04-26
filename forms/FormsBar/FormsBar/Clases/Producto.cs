using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsBar.Clases
{
    public class Producto
    {
        public int Id { get; set; }
        public int IdCategoria { get; set; }    

        public string Nombre     { get; set; }
        public double PrecioUnitario { get; set; }

        public Producto(int id, int idcategoria, string nombre, double precioUnitario)
        {
            Id = id;
            IdCategoria = idcategoria;
            Nombre = nombre;
            PrecioUnitario = precioUnitario;
        }
    }
}
