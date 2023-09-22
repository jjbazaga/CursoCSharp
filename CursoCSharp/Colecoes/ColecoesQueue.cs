using System;
using System.Collections;
using System.Collections.Generic;

namespace CursoCSharp.Colecoes {
    class ColecoesQueue {
        public static void Executar() {
            var fila = new Queue<string>();
            fila.Enqueue("Fulano");
            fila.Enqueue("Cicrano");
            fila.Enqueue("Beltrano");

            foreach(var item in fila) {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (string item in fila) {
                Console.WriteLine(item);
            }

            var salada = new Queue();
            salada.Enqueue(3);
            salada.Enqueue("Item");
            salada.Enqueue(true);
            salada.Enqueue(3.14);

            foreach (var item in salada) {
                Console.WriteLine(item);
            }
            Console.WriteLine(salada.Contains("Item"));
        }
    }
}
