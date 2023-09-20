using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            int idade = 18;
            bool possuiCNH = false;
            bool podeDirigir;

            if (idade >= 18 && possuiCNH) {
                podeDirigir = true;
                Console.WriteLine("Você pode dirigir.");
            } else if (idade >= 18) {
                podeDirigir = false;
                Console.WriteLine("Você não pode dirigir pois não possui CNH.");
            } else {
                podeDirigir = false;
                Console.WriteLine("Você não tem a idade permitida para dirigir.");
            }
        }
    }
}