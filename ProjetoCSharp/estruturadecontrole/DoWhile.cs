using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.estruturadecontrole
{
    public class DoWhile
    {
        public static void Execute()
        {
            int [] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int indice = 0;
            do
            {
                Console.WriteLine($"Indice: {(indice)} número: {array[indice]}");
                indice++;
            }
            while (indice < 10);

            Console.ReadKey();
        }
    }
}
