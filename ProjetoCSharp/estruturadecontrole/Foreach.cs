using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.estruturadecontrole
{
    public class Foreach
    {
        public static void Execute()
        {
            List<string> Frutas = new List<string>();

            Frutas.Add("Maça");
            Frutas.Add("Tangerina");
            Frutas.Add("Laranja");
            Frutas.Add("Banana");
            Frutas.Add("Goiaba");
            Frutas.Add("Acerola");

            foreach(string frutas in Frutas)
            {
                Console.WriteLine(frutas);
            }

            Console.ReadKey();
        }
    }
}
