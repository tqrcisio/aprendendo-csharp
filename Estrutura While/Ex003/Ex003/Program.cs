using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            int cod = int.Parse(Console.ReadLine());
            int qtdeAlcool = 0, qtdeGasolina = 0, qtdeDielsel = 0;
            while (cod != 4) {
                if (cod == 1) {
                    qtdeAlcool++;
                    cod = int.Parse(Console.ReadLine());
                } else if (cod == 2) {
                    qtdeGasolina++;
                    cod = int.Parse(Console.ReadLine());
                } else if (cod == 3) {
                    qtdeDielsel++;
                    cod = int.Parse(Console.ReadLine());
                } else {
                    cod = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("MUITO OBRIGADO!");
            Console.WriteLine("Alcool: " + qtdeAlcool);
            Console.WriteLine("Gasolina: " + qtdeGasolina);
            Console.WriteLine("Dielsel: " + qtdeDielsel);
        }
    }
}