using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic["rojo"] = "red";
            dic["verde"] = "green";
            dic["amarillo"] = "yellow";

            foreach (KeyValuePair<string, string> kvp in dic)
                Console.WriteLine($"{kvp.Key} significa: {kvp.Value}");

            if (dic.ContainsKey("rojo"))
                Console.WriteLine(dic["rojo"]);

            // dic.Remove("Rojo");

            Console.ReadKey();
        }
    }
}
