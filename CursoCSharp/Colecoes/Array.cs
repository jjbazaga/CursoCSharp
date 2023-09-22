using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {
        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Jorge";
            alunos[1] = "José";
            alunos[2] = "Bazaga";
            alunos[3] = "Marta";
            alunos[4] = "Danielle";
            //alunos[5] = "Renato"; // São somente 5 elementos a partir do index 0
            foreach(string aluno in alunos) {
                Console.WriteLine(aluno);
            }
            Console.Write("Entre com o numero de notas do aluno: ");
            int n = int.Parse(Console.ReadLine());
            double[] notas = new double[n];
            double soma = 0.0;
            for(int i = 0; i < notas.Length; i++) {
                Console.Write($"Nota nº " + (i + 1) + ": ");
                notas[i] = double.Parse(Console.ReadLine());
            }
            foreach(var nota in notas) {
                soma += nota;
            }
            double media = soma / notas.Length;
            Console.WriteLine();
            Console.WriteLine("MÉDIA GERAL");
            Console.WriteLine("Este aluno tem média de " + media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y', '!' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
        }
    }
}