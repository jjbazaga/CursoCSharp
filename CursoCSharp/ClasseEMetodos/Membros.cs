using System;

namespace CursoCSharp.ClasseEMetodos {
    class Membros {
        public static void Executar() {
            Pessoas sicrano = new Pessoas();
            sicrano.Nome = "Renato";
            sicrano.Idade = 21;
            Console.WriteLine(sicrano.Apresentar());
            Console.WriteLine(sicrano.Apresentar().ToUpper());
            Console.WriteLine(sicrano.Nome.Length);

            var fulano = new Pessoas();
            fulano.Nome = "Beto";
            fulano.Idade = 35;
            Console.WriteLine(fulano.Apresentar());
            Console.WriteLine(fulano.Apresentar().ToLower());
            Console.WriteLine(fulano.Nome.Length);
        }
    }
}