using System;
namespace Ex005 {
    internal class Aluno {
        public string Nome;
        public double A1;
        public double A2;
        public double A3;

        public double NotaFinal() {
            return A1 + A2 + A3;
        }
        public string Resultado() {
            string saida = "";
            double diff = 60.00 - NotaFinal();
            if (NotaFinal() >= 60.00) {
                saida = "APROVADO";
            } else {
                saida = $"REPROVADO\nFALTARAM {diff} PONTOS";
            }
            return saida;
        }
        public override string ToString() {
            return $"NOTA FINAL = {NotaFinal()}\n{Resultado()}";
        }
    }
}
