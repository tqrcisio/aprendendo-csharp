
namespace Ex006 {
    class ConversorDeMoeda {
        public static double DolarParaReal(double cotacao, double dolar) {
            double total = dolar * cotacao;
            double totalFinal = total += total * 0.06;
            return totalFinal;
        }
    }
}
