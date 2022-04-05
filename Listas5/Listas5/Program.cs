using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Producto producto1 = new Producto(1, "lapiz", 1.23);
            Producto producto2= new Producto(2, "goma", 0.50);
            Producto producto3 = new Producto(3, "cuaderno", 3.20);

            Dictionary<int, Producto> dic = new Dictionary<int, Producto>();
            dic.Add(producto1.Codigo, producto1);
            dic.Add(producto2.Codigo, producto2);
            dic.Add(producto3.Codigo, producto3);

            foreach (KeyValuePair<int, Producto> kvp in dic)
                Console.WriteLine($"El producto número {kvp.Key} es: {kvp.Value.Descripcion} con precio {kvp.Value.Precio}");

            Console.WriteLine(dic[2].Descripcion);

            Console.ReadKey();
        }
    }
}
