﻿namespace MembrosEstaticos_3 {
     class Calculadora {
        public static double pi = 3.14;

        public static double Circunferencia(double r) {
            return 2.0 * pi * r;
        }
        public static double Volume(double r) {
            return 4.0 / 3.0 * pi * r * r * r;
        }
    }
}
