﻿using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.Write("Digite o valor de N: ");
            int n = int.Parse(Console.ReadLine());
            int res = 1;
            for (int i = 1; i <= n; i++) {
                res *= i;
            }
            Console.WriteLine($"O fatorial de {n} é igual à {res}");
        }
    }
}
