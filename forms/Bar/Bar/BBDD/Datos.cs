using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bar.Clases;

namespace Bar.BBDD
{
    public static class Datos
    {
        private static string str_connection = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Bar;Integrated Security=True";
        public static List<Categoria> lista_categorias = new List<Categoria>();
        public static List<Articulo> lista_articulos = new List<Articulo>();

        public static void Categorias()
        {
            string sel = "SELECT * FROM Categorias";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                lista_categorias.Add(new Categoria((int)r[0], (string)r[1]));

            r.Close();
            con.Close();
        }

        public static void ArticulosCategoria(Categoria categoria)
        {
            string sel = $"SELECT * FROM Articulo WHERE idCategoria = {categoria}";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                lista_articulos.Add(new Articulo((int)r[0], (int)r[1], (string)r[2], Double.Parse($"{r[3]}")));

            r.Close();
            con.Close();
        }
    }
}
