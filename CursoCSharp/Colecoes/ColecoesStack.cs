using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesStack {
        public static void Executar() {
            var pilha = new Stack<string>(); // Aqui com generics
            pilha.Push("Antonio");
            pilha.Push("Maria");
            pilha.Push("José");

            foreach (Object obj in pilha) {
                Console.WriteLine(obj);
            }

            pilha.Pop(); // sai o último a ser inserido na pilha de memória stack

            Console.WriteLine();
            foreach (Object obj in pilha) {
                Console.WriteLine(obj);
            }

            var pilha2 = new Stack(); // sem generics
            pilha2.Push("Roberto");
            pilha2.Push(true);
            pilha2.Push(3.14);
            pilha2.Push('k');

            Console.WriteLine();
            foreach (Object obj in pilha2) {
                Console.WriteLine(obj);
            }

            pilha2.Pop();

            Console.WriteLine();
            foreach (Object obj in pilha2) {
                Console.WriteLine(obj);
            }

            Console.WriteLine($"\nPeek: {pilha2.Peek()}");

            Console.WriteLine();
            foreach (Object obj in pilha2) {
                Console.WriteLine(obj);
            }
        }
    }
}
