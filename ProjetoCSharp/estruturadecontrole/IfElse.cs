using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.estruturadecontrole
{
    public class IfElse
    {
        public static void Execute()
        {
            int numeroDeComparacao = 1;
            int numeroDeComparacao2 = 2;

            if(numeroDeComparacao == numeroDeComparacao2)
            {
                Console.WriteLine("Números iguais");
            } 
            else
            {
                Console.WriteLine("Números diferentes");
            }
            Console.ReadKey();
        }
    }
}
