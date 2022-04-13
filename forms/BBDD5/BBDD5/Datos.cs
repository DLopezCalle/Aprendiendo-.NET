using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD5
{
    internal class Datos
    {
        public List<Amigo> Amigos()
        {
            List<Amigo> lista_amigos = new List<Amigo>();
            string s = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Prueba;Integrated Security=True;Pooling=False";
            string sel = "SELECT * FROM Amigos";

            SqlConnection con = new SqlConnection(s);

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

        public void Listar()
        {
            foreach (Amigo amigo in Amigos())
            {
                Console.WriteLine(amigo);
            }
        }

        public int Insertar(Amigo amigo)
        {
            string s = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Prueba;Integrated Security=True;Pooling=False";
            string sel = $"INSERT INTO Amigos (nombre, email) VALUES ('{amigo.Nombre}', '{amigo.Email}')";

            SqlConnection con = new SqlConnection(s);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            int filas = cmd.ExecuteNonQuery();
            con.Close();

            return filas;
        }

        public int Borrar(int id)
        {
            string s = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Prueba;Integrated Security=True;Pooling=False";
            string sel = $"DELETE FROM Amigos WHERE id = {id}";

            SqlConnection con = new SqlConnection(s);

            con.Open();

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sel;

            int filas = cmd.ExecuteNonQuery();
            con.Close();

            return id;
        }

        public void ModificarAmigo(Amigo amigo)
        {

        }
    }
}
