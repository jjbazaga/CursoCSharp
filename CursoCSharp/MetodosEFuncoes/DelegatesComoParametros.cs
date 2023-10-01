using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class DelegatesComoParametros {

        public delegate int Operacao(int x, int y); //delegate retorna inteiro, recebe dois inteiros

        public static int Soma(int x, int y) {  // Função atrelada ao delegate, retorna inteiro recebe dois inteiros
            return x + y;
        }

        public static string Calculadora(Operacao op, int x, int y) {  // Função retorna string, recebe função(delegate) e dois inteiros
            var resultado = op(x, y);
            return "Resultado: " + resultado;
        }

        public static void Executar() {
            Operacao subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calculadora(subtracao, 3, 2));

            Console.WriteLine(Calculadora(Soma, 3, 2));
        }
    }
}
