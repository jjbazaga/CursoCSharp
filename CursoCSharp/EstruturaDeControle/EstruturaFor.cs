using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaFor {
        public static void Executar() {

            double somatorio = 0;

            Console.Write("Informe o tamanho da turma: ");
            int.TryParse(Console.ReadLine(), out int tamanhoTurma);

            for (int i = 1; i <= tamanhoTurma; i++) {
                Console.Write($"Entre com a nota de numero {i}: ");
                double.TryParse(Console.ReadLine(), out double nota);
                somatorio += nota;
            }
            Console.WriteLine($"Media das notas: {somatorio / tamanhoTurma}");
            Console.WriteLine();

            Console.WriteLine("OS NÚMEROS SÃO: ");
            for (int i = 0; i <= 10; i++) {
                Console.Write($"|{i}| ");
            }
            Console.WriteLine();
        }
    }
}