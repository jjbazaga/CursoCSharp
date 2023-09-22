using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Params {

        public static void Recepcionar(params string[] pessoas) {
            foreach (var obj in pessoas) {
                Console.WriteLine($"Olá {obj}");
            }
        }

        public static void Numeros(params int[] inteiros) {
            foreach (var obj in inteiros) {
                Console.Write($"Inteiro: {obj} | ");
            }
        }

        public static void Executar() {
            Recepcionar("André", "Thiago", "Natália", "Manoel", "Renata", "Jorge", "Marcelo", "Fred");
            for (int i = 1; i <= 10; i++){
                Numeros(i);
            }
            Console.WriteLine();
        }
    }
}