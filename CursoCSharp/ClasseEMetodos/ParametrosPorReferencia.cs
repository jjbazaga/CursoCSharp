using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    class ParametrosPorReferencia {

        public static void PassagemValor(int numero) {
            numero = 7;
            Console.WriteLine("Valor no metodo " + numero);
        }

        public static void PassagemReferencia(ref int numero) {
            numero = 7;
            Console.WriteLine("Valor no metodo " + numero);
        }

        public static void PassagemSaida(out int numero) {
            numero = 7;
            Console.WriteLine("Valor no metodo " + numero);
        }

        public static void Media(params int[] numero) {
            int soma = 0;
            foreach(int a in numero) {
                soma = soma + a;
            }
            Console.WriteLine("Média: " + soma /numero.Length);
        }

        public static void Executar() {
            int numero = 1;
            ParametrosPorReferencia.PassagemValor(numero);
            Console.WriteLine("No Main " + numero);
            ParametrosPorReferencia.PassagemReferencia(ref numero);
            Console.WriteLine("No Main " + numero);
            ParametrosPorReferencia.PassagemSaida(out numero);
            Console.WriteLine("No Main " + numero);
            ParametrosPorReferencia.Media(20, 30, 40, 50, 60);

        }
    }
}