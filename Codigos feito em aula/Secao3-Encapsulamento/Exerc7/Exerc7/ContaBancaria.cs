using System;
using System.Globalization;

namespace Exerc7 {
    internal class ContaBancaria {
        public int _numero { get; private set; }
        public string _titular { get; set; }
        public double _saldo { get; private set; }

        public ContaBancaria(int numero, string titular) {
            _numero = numero;
            _titular = titular;
        }

        public ContaBancaria(int numero, string titular, double depositoInicial) {
            _numero = numero;
            _titular = titular;
            Depositar(depositoInicial);
        }

        public void Depositar(double valorDeposito) {
            if (valorDeposito > 0) {
                _saldo += valorDeposito;
            }
        }
        public void Sacar(double valorSaque) {
            _saldo -= valorSaque + 5.0;
        }
        public override string ToString() {
            return $"Conta {_numero}, Titular: {_titular}, Saldo: $ {_saldo:F2}";
        }
    }
}
