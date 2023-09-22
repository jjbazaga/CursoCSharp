using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class UsandoBreak {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);

            Console.WriteLine($"O número que queremos é {numero}");

            for (int i = 1; i < 51; i++) {
                Console.WriteLine("{0} é o numero que queremos? ", i);
                if (i == numero) {
                    Console.WriteLine("Sim!");
                    break;
                } else {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("Fim!");
        }
    }
}
