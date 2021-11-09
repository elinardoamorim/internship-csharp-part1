using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Fundamentos
{
    public class CalculandoPoupanca2
    {
        public static void Execute()
        {
            Console.WriteLine("Executando Projeto - Calcula Poupança");

            double valorInvestido = 1000;

            for(int contadorMes = 1; contadorMes <= 12; contadorMes++)
            {
                valorInvestido = valorInvestido + (valorInvestido * 0.0036);
                Console.WriteLine("Após " + contadorMes + " meses, você terá R$ " + valorInvestido);
            }




            Console.ReadLine();
        }
    }
}
