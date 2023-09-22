using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Entre com sua nota: ");
            Double.TryParse(Console.ReadLine(), out double nota);

            if (nota >= 9.0) {
                Console.WriteLine("Aprovado");
                Console.WriteLine("Quadro de honra!");
            } else if (nota >= 7.0) {
                Console.WriteLine("Aprovado!");
            } else if (nota >= 5.0) {
                Console.WriteLine("Recuperação!");
            } else {
                Console.WriteLine("Te vejo na próxima...");
            }
            Console.WriteLine("Fim!");
        }
    }
}