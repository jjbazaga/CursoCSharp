using System;
using System.Globalization;

namespace CursoCSharp.Fundamentos {
    class Conversao {
        public static void Executar() {
            int inteiro = 10;
            double quebrado = inteiro;
            Console.WriteLine(quebrado);

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            Console.Write("Entre sua idade: ");
            string idad = Console.ReadLine();
            //int idade = int.Parse(Console.ReadLine());   OU...
            int idade = Convert.ToInt32(idad);
            Console.WriteLine("Sua idade é de {0} anos.", idade);

            Console.Write("Entre com salário: ");
            //string salari = Console.ReadLine();
            //double salario = Convert.ToDouble(salari);    OU...
            double salario = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("O Salário é de {0}.", salario.ToString("C2"));

            Console.Write("Digite o primeiro numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);   // Tenta se não fror inteiro joga 0
            Console.WriteLine("Resultado1: {0}", numero1);

            Console.Write("Digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);    //  // Tenta se não fror inteiro joga 0
            Console.WriteLine("Resultado2: {0}", numero2);
        }
    }
}
