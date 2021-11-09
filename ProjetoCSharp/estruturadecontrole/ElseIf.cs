using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.estruturadecontrole
{
    public class ElseIf
    {
        public static void Execute()
        {
            int numeroCondicional = 7;
            int numeroCondicional2 = 2;

            if(numeroCondicional > numeroCondicional2)
            {
                int valorResultado = numeroCondicional + numeroCondicional2;
                Console.WriteLine($"{numeroCondicional} + {numeroCondicional2} = { valorResultado}");
            }
            else if(numeroCondicional < numeroCondicional2)
            {
                int valorResultado = numeroCondicional - numeroCondicional2;
                Console.WriteLine($"{ numeroCondicional} - { numeroCondicional2} = {valorResultado}");
            }
            else
            {
                int valorResultado = numeroCondicional * numeroCondicional2;
                Console.WriteLine($"{numeroCondicional} * {numeroCondicional2} = {valorResultado}");
            }
        }
    }
}
