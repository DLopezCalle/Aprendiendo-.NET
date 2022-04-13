using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaro el string de conexción
            string s = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Prueba;Integrated Security=True;Pooling=False";

            // Declaro el INSERT
            int id = 4;
            string sel = $"DELETE FROM Amigos WHERE id = {id}";

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
