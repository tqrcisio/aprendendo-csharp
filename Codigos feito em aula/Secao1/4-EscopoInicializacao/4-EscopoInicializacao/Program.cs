using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            string diaDaSemana = "Segunda-Feira";
            string isFds;
            if (diaDaSemana == "Domingo" || diaDaSemana == "Sábado") { // VERIFICA SE É DOMINGO OU SÁBADO
                isFds = "Sim";
            }
            Console.WriteLine(isFds); 
            // O programa não executa pois a variável foi delcarada no programa, mas só foi iniciada dentro da estrutura if,
            // Só será possivel executar dessa forma se for adicionado um else nessa estrutura setando um valor para a variavel caso a condição seja falsa
        }
    }
}