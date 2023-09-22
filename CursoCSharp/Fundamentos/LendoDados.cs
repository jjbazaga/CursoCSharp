using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class LendoDados {
        public static void Executar() {
            Console.Write("Qual o seu nome? ");
            string nome = Console.ReadLine();

            Console.Write("Qual sua idade? ");           
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Qual o seu salário mensal? ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Meu nome é {0} e tenho a idade de {1} anos e recebo R$ {2} por mês!",
                nome, idade, salario);
        }
    }
}
