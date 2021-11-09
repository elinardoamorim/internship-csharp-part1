using ProjetoCSharp.Bytebank;
using ProjetoCSharp.estruturadecontrole;
using ProjetoCSharp.Fundamentos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoCSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var center = new ExerciseCenter(new Dictionary<string, Action>() {
                {"Variaveis - Fundamentals", Variaveis.Execute},
                {"Interpolação - Fundamentals", Interpolacao.Execute},
                {"Laço de repetição com While - Fundamentals", CalculaPoupanca.Execute },
                {"Laço de repetição com For - Fundamentals", CalculandoPoupanca2.Execute },
                {"Laço de repetição com For Encadeado - Fundamentals", CalculandoInvestimentoLongoPrazo.Execute },
                {"Laço de repetição For Encadeado com Break - Fundamentals", ForEncadeadoComBreak.Execute },
                {"Praticando laço de repetição While e For - Fundamentals", PraticandoWhileFor.Execute },
                {"Estrutura de Controle - If/Else", IfElse.Execute},
                {"Estrutura de Controle - Else/If", ElseIf.Execute},
                {"Estrutura de Controle - Switch Case", SwitchCase.Execute},
                {"Estrutura de Controle - For", For.Execute},
                {"Estrutura de Controle - While", While.Execute},
                {"Estrutura de Controle - DoWhile", DoWhile.Execute},
                {"Estrutura de Controle - Foreach", Foreach.Execute}

            });

            center.SelectAndRun();

        }
    }
}
