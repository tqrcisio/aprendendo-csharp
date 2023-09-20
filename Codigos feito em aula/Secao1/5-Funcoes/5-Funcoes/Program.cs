using System;
using System.Globalization;

namespace Program {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite 3 numeros:");
            string[] num = Console.ReadLine().Split(' ');
            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);
            int n3 = int.Parse(num[2]);
            int maior = Maior(n1,n2,n3);
            Console.WriteLine("O numero maior é "+maior);
        }
        static int Maior(int a, int b, int c) {
            int m;
            if(a > b && a > c) {
                m = a;
            } else if(b > c) {
                m = b;
            } else {
                m = c;
            }
            return m;
        }
    }
}