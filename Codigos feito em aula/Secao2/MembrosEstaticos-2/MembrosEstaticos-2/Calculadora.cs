
namespace MembrosEstaticos_2 {
    internal class Calculadora {
        public double pi = 3.14;
        public double r;

        public double Circunferencia() {
            return 2.0 * pi * r;
        }
        public double Volume() {
            return  4.0 / 3.0 * pi * r * r * r;
        }
    }
}
