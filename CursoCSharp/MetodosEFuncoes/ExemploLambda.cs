using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action algoConsole = () => {
                Console.WriteLine("Lambda com C#!");
            }; // Action: delegate que guarda ações,
               // que podem ser utilizadas mais tarde, sempre void.
            algoConsole();  // Invocando algo no console

           //Criando uma função Func, que retorna um inteiro.
           Func<int> jogarDado = () => {
               Random random = new Random();
               return random.Next(1, 7);
           };

            Console.WriteLine(jogarDado());

            //Func<int, string> conversorHex = (int numero) => {
            //    return numero.ToString("X");
            //}; 

            // OU:

            Func<int, string> conversorHex = numero => numero.ToString("X");

            Console.WriteLine(conversorHex(223));

            //Func<int, int, int, string> formatarData = (dia, mes, ano) => {
            //    return String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            //};

            //OU:
            Func<int, int, int, string> formatarData = (dia, mes, ano) => String.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(17, 01, 1953));
        }
    }
}