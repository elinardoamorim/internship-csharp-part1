using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Fundamentos
{
    public class Variaveis
    {
        public static void Execute()
        {
            string valorString;
            int valorDouble;
            
            Console.WriteLine("Digite um valor: ");
            valorDouble = Convert.ToInt32(Console.ReadLine());

            //valorDouble = double.Parse(valorString);
            //valorDouble = Convert.ToDouble(valorString);

            Console.WriteLine("Valor em double usando parse: " + valorDouble);
            Console.WriteLine("Valor em double usando convert: " + valorDouble);
        }
    }
}
