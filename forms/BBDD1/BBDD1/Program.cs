using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBDD1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaro el string de conexción
            string s = @"Data Source=DESKTOP-HHR4GD7;Initial Catalog=Prueba;Integrated Security=True;Pooling=False";

            // Declaro la SELECT
            string sel = "SELECT * FROM Amigos";

            // Creo la conexión
            SqlConnection con = new SqlConnection(s);

            // Abro la cone
            con.Open();

            // Me creo un comando
            SqlCommand cmd = con.CreateCommand();

            // Asigno la SELECT al comando
            cmd.CommandText = sel;

            // Ejecuto el comando
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
            {
                Console.WriteLine($"{r[0]}\t{r[1]},\t Mail: {r[2]}");
            }

            // Cierro el Reader
            r.Close();
            // Cierro la conexión
            con.Close();

            Console.ReadKey();
        }
    }
}
