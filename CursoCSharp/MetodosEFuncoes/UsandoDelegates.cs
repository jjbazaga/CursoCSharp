using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class UsandoDelegates {

        delegate double Soma(double a, double b);
        delegate void ImprimirSoma(double a, double b);

        static double MinhaSoma(double a, double b) {
            return a + b;
        }

        static void MeuImprimirSoma(double a, double b) {
            Console.WriteLine(a + b);
        }

        public static void Executar() {
            Console.WriteLine(MinhaSoma(3,4)); // Sem associação com delegates
            MeuImprimirSoma(7, 8);
            Console.WriteLine();

            Soma operSoma = MinhaSoma; // Associados aos delegates
            ImprimirSoma impSoma = MeuImprimirSoma;

            Console.WriteLine(operSoma(32.7, 83.8));
            impSoma(1.7, 2.3);
            Console.WriteLine();

            Func<double, double, double> operacao = MinhaSoma; // Função recebendo metodo
            Console.WriteLine(operacao(2.7, 7.7));

            Action<double, double> imprimir = MeuImprimirSoma;
            imprimir(15.6, 8.9);
        }
    }
}