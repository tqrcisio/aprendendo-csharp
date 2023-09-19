using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            string[] ab = Console.ReadLine().Split(' ');
            int a = int.Parse(ab[0]);
            int b = int.Parse(ab[1]);
            int tempo = 0;
            int maior = Math.Max(int.Parse(ab[0]), int.Parse(ab[1]));
            int menor = Math.Min(int.Parse(ab[0]), int.Parse(ab[1]));
            if (a > b) {
                tempo = 24 - a + b;
            } else if (b > a){
                tempo = b - a;
            } else {
                tempo = 24;
            }
            Console.WriteLine(tempo);
        }
    }
}