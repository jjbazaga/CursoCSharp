using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaIf {
        public static void Executar() {
            bool bomComportamento = false;

            Console.Write("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.Write("O aluno possui bom comportamento? (S/N): ");
            entrada = Console.ReadLine();

            bomComportamento = entrada.ToLower() == "s";

            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }
            Console.WriteLine("Fim");
        }
    }
}
