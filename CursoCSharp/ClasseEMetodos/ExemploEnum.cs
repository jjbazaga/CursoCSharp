using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class ExemploEnum {

        public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };

        public class Filme {
            public string Titulo;
            public Genero GeneroDoFilme;           
        }

        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Noite dos Bozios";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;
            Console.WriteLine("Titulo para familia: {0} é {1}!",
                filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}