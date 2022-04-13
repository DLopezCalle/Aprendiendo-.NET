using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaro el string de conexción
            string s = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Prueba;Integrated Security=True;Pooling=False";

            // Declaro el INSERT
            string nombre = "Pedro";
            string email = "pedro@gmail.com";
            string sel = $"INSERT INTO Amigos (nombre, email) VALUES ('{nombre}', '{email}')";

            // Creo la conexión
            SqlConnection con = new SqlConnection(s);

            // Abro la cone
            con.Open();

            // Me creo un comando
            SqlCommand cmd = con.CreateCommand();

            // Asigno la SELECT al comando
            cmd.CommandText = sel;

            // Ejecuto el comando
            int filas = cmd.ExecuteNonQuery();

            Console.WriteLine($"({filas}) filas afectadas");

            // Cierro la conexión
            con.Close();

            Console.ReadKey();
        }
    }
}
