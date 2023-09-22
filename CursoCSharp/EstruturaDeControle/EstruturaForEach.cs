using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaForEach {
        public static void Executar() {
            var alunos = new string[] { "José", "Maria", "João", "Mané" };
            foreach(var obj in alunos) {
                Console.Write($"|{obj}|");
            }
            Console.WriteLine();

            var palavra = "Opa!";
            foreach(var obj in palavra) {
                Console.Write(" " + obj + " ");
            }
        }
    }
}