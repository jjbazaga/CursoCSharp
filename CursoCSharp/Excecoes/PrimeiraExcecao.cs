using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Excecoes {

    public class Conta {
        double Saldo;

        public Conta(double saldo) {
            Saldo = saldo;
        }

        public void Sacar(double valor) {
            if (valor > Saldo) {
                throw new ArgumentException("Saldo insuficiente!");
            } else {
                Saldo -= valor;
            }
        }
    }

    class PrimeiraExcecao {
        public static void Executar() {
            var conta = new Conta(1_223.45);

            try {
                conta.Sacar(1_600.00);
                Console.WriteLine("Retirada com sucesso!");
            } catch (Exception e) {
                Console.WriteLine(e.Message);
            } finally {
                Console.WriteLine("Obrigado");
            }
        }
    }
}