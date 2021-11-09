using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp.Fundamentos
{
    public class PraticandoWhileFor
    {
        public static void Execute()
        {
            Console.WriteLine("Praticando o que foi visto em aula");
            /*
            int contador = 1;

            while(contador <= 10)
            {
                Console.WriteLine(contador);
                contador++;
            }

            for(contador = 1;  contador <= 10; contador++)
            {
                Console.WriteLine(contador);
            }
            
            for (int linha = 0; linha <= 5; linha++)
            {
                for (int coluna = 0; coluna <= 5; coluna++)
                {

                    if ( coluna >= linha )
                    {
                        break;
                    }
                    Console.Write( coluna + 1);
                }
                Console.WriteLine();
            }
            
            for(int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                for (int contador = 1; contador <= 10; contador++)
                {
                    Console.WriteLine(multiplicador + " * " + contador + " = " + multiplicador * contador);
                }
                Console.WriteLine();
            }
            
            for(int i = 1; i <= 100; i++)
            {
                if(i % 3 == 0)
                {
                    Console.WriteLine(i + " é multiplo de 3");
                }
            }
            */
            int fatorial = 1;
            for (int i = 1; i <= 10; i++)
            {
                fatorial *= i;
                Console.WriteLine("Fatorial " + i + " é " + fatorial);

            }

            Console.ReadLine();
        }
    }
}
