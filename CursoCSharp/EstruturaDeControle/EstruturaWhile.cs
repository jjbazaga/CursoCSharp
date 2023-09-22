using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControle {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;
            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;

            Console.WriteLine("**********            JOGO DOS NUMEROS             ***********");
            Console.WriteLine("Escolha um número de 1 a 15, e tenta advinhar o numero secreto");
            Console.WriteLine();

            while (tentativasRestantes > 0 && !numeroEncontrado) {
                Console.Write("Insira seu palpite: ");
                int.TryParse(Console.ReadLine(), out palpite);

                if (palpite == numeroSecreto) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine($"Acertou vagabundo, o numero é " +
                        $"{numeroSecreto} em {++tentativas} tentativas!");
                    tentativas--;
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("O valor é menor... Tente novamente!");                   
                } else {
                    Console.WriteLine("O valor é maior... Tente novamente!");
                }
                Console.WriteLine($"Numero de tentativas: {++tentativas}");
                Console.WriteLine($"Tentativas restantes: {--tentativasRestantes}");
                Console.WriteLine();
            }           
        }
    }
}