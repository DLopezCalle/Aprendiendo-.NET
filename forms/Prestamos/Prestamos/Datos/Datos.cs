using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prestamos.Clases;

namespace Prestamos.Datos
{
    public static class Datos
    {
        private static string str_connection = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog = Prestamos; Integrated Security = True; Pooling=False";

        public static List<Amigo> Amigos()
        {
            List<Amigo> lista_amigos = new List<Amigo>();
            string sel = "SELECT * FROM Amigos";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                lista_amigos.Add(new Amigo((int)r[0], (string)r[1], (string)r[2]));
            }

            r.Close();
            con.Close();

            return lista_amigos;
        }

        public static Amigo Amigo(int id)
        {
            foreach (Amigo amigo in Amigos())
                if (amigo.Id == id)
                    return amigo;
            return null;          
        }

        public static void ListarAmigos()
        {
            foreach (Amigo amigo in Amigos())
            {
                Console.WriteLine(amigo);
            }
        }

        public static List<Libro> Libros()
        {
            List<Libro> lista_libros = new List<Libro>();
            string sel = "SELECT * FROM Libros";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                lista_libros.Add(new Libro((int)r[0], (string)r[1]));
            }

            r.Close();
            con.Close();

            return lista_libros;
        }
        public static Libro Libro(int id)
        {
            foreach (Libro libro in Libros())
                if (libro.Id == id)
                    return libro;
            return null;
        }

        public static void ListarLibros()
        {
            foreach (Libro libro in Libros())
            {
                Console.WriteLine(libro);
            }
        }

        public static List<Prestamo> NoDevueltos()
        {
            List<Prestamo> lista_prestamos = new List<Prestamo>();
            string sel = "SELECT * FROM Prestamos WHERE devuelto = 0";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                lista_prestamos.Add(new Prestamo((int)r[0], Amigo((int)r[1]), Libro((int)r[2]), false));
            }

            r.Close();
            con.Close();

            return lista_prestamos;
        }

        public static List<Libro> LibrosDisponibles()
        {
            List<Libro> lista_libros = Libros();
            List<Prestamo> lista_prestamos = NoDevueltos();

            foreach (Prestamo prestamo in lista_prestamos)
                lista_libros.Remove(lista_libros.Find(li => li.Id == prestamo.Libro.Id));

            return lista_libros;
        }

        public static int Insertar(Amigo amigo)
        {
            string sel = $"INSERT INTO Amigos (nombre, email) VALUES ('{amigo.Nombre}', '{amigo.Email}')";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            int filas = cmd.ExecuteNonQuery();
            con.Close();

            return filas;
        }

        public static int Borrar(int id)
        {
            string sel = $"DELETE FROM Amigos WHERE id = {id}";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            int filas = cmd.ExecuteNonQuery();
            con.Close();

            return id;
        }

        public static int HacerPrestamo(Libro libro, Amigo amigo)
        {
            string sel = $"INSERT INTO Prestamos (idAmigo, idLibro, devuelto) VALUES ('{amigo.Id}', '{libro.Id}', 0)";

            SqlConnection con = new SqlConnection(str_connection);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            int filas = cmd.ExecuteNonQuery();
            con.Close();

            return filas;
        }

        public static int DevolverPrestamo(int id)
        {
            string sel = $"UPDATE Prestamos SET devolver = 1 WHERE id = {id}";

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
