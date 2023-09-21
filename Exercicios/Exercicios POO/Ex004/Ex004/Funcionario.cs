using System;
namespace Ex004 {
    internal class Funcionario {
        public string Nome;
        public double Salario;
        public double Imposto;

        public double SalarioLiquido() {
            return Salario - Imposto;
        }
        public double AumentarSalario(double porcentagem) {
            return Salario += Salario * (porcentagem / 100);
        }
        public override string ToString() {
            return Nome + ", " + " $ " + SalarioLiquido();
        }
    }
}
