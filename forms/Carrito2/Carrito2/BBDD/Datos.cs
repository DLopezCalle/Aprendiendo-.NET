using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Carrito2.Clases;

namespace Carrito2.BBDD
{
    public static class Datos
    {
        private static string str_connection = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Compras;Integrated Security=True";
        public static Usuario usuario = new Usuario();
        public static List<Articulo> lista_articulos = new List<Articulo>();
        public static List<Carrito> lista_carrito = new List<Carrito>();
        public static double total = 0;

        public static bool Logear(string nombre, string pass)
        {
            string sel = $"SELECT * FROM Usuarios WHERE nombre = '{nombre}' AND pass = '{pass}'";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                usuario = new Usuario((int)r[0], (string)r[1], (string)r[2]);

            r.Close();
            con.Close();

            if (usuario.Id != 0)
                return true;
            return false;
        }

        public static void Articulos()
        {            
            string sel = "SELECT * FROM Articulos";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                lista_articulos.Add(new Articulo((int)r[0], (string)r[1], Double.Parse($"{r[2]}")));

            r.Close();
            con.Close();
        }

        public static Articulo Articulo(int id)
        {
            Articulo articulo = null;

            string sel = $"SELECT * FROM Articulos WHERE id = '{id}'";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                articulo = new Articulo((int)r[0], (string)r[1], Double.Parse($"{r[2]}"));

            r.Close();
            con.Close();

            return (articulo);
        }

        public static int NuevaFactura()
        {
            string sel = $"INSERT INTO Facturas (idUsuario, fecha) VALUES ('{usuario.Id}', '{DateTime.Now}')";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            int filas = cmd.ExecuteNonQuery();
            con.Close();

            return filas;
        }
    }
}
