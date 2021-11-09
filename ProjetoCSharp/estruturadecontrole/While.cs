using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.estruturadecontrole
{
    public class While
    {
        public static void Execute()
        {
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 , 10 };
            int indice = 0;

            while(indice < 10)
            {
                Console.WriteLine($"{(indice + 1)}º número: {array[indice]}");
                indice++;
            }

            Console.ReadKey();

        }
    }
}
