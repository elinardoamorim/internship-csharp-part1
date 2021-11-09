using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.estruturadecontrole
{
    public class For
    {
        public static void Execute()
        {
            int fatorial = 1;

            // Inicialização; Condição; Incremento/Decremento;
            for(int numeroFatorial = 1; numeroFatorial <= 10; numeroFatorial++)
            {
                fatorial *= numeroFatorial;

                Console.WriteLine($"Fatorial de {numeroFatorial}! é {fatorial}");
            }
        }
    }
}
