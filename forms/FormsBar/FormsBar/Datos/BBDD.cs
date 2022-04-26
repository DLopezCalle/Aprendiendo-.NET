using FormsBar.Clases;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsBar.Datos
{
    public static class BBDD
    {
        private static string s = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Bar;Integrated Security=True";
        public static List<Categoria> Categorias()
        {
            List<Categoria> list = new List<Categoria>();
            string sel = "SELECT * FROM Categorias";
            SqlConnection conn = new SqlConnection(s);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sel;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Categoria(dr.GetInt32(0), dr.GetString(1)));
            }
            dr.Close();
            conn.Close();
            return list;

        }

        public static List<Producto> Productos(int IdCategoria)
        {
            List<Producto> list = new List<Producto>();
            string sel = $"SELECT * FROM Articulos WHERE idCategoria = {IdCategoria}";
            SqlConnection conn = new SqlConnection(s);
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sel;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(new Producto(dr.GetInt32(0),dr.GetInt32(1),dr.GetString(2),dr.GetSqlMoney(3).ToDouble()));
            }
            dr.Close();
            conn.Close();
            return list;

        }
    }
}
