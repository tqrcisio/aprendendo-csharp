using System;
using System.Globalization;

namespace Ex003 {
    class Retangulo {
        public double Largura;
        public double Altura;

        public double Area() {
            return Largura * Altura;
        }
        public double Perimetro() {
            double res = (Largura * 2) + (Altura * 2);
            return res;
        }
        public double Diagonal() {
            double res = Math.Sqrt((Largura * Largura) + Altura * Altura);
            return res;
        }
    }
}

