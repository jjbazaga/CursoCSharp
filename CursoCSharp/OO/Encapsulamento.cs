using System;
using Encapsulamento;
using static CursoCSharp.OO.FilhoNaoReconhecido;

namespace CursoCSharp.OO {

    public class FilhoNaoReconhecido : SubCelebridade {
        public new void MeusAcessos() {
            Console.WriteLine("FilhoNaoReconhecido...");

            Console.WriteLine(InfoPublica); //public, em todos os projetos assembly
            Console.WriteLine(CordoOlho); //protected, por herança
            //Console.WriteLine(NumeroCelular); //internal, somente no mesmo projeto
            Console.WriteLine(JeitoDeFalar); // internal e protected
            //Console.WriteLine(SegredoDeFamilia); // private protected - somente dentro do mesmo projeto ou classe
            //Console.WriteLine(UsaMuitoPhotoshop); //private, somente na classe
        }

        public class AmigoDistante {
            public readonly SubCelebridade amiga = new SubCelebridade();

            public void MeusAcessos() {
                Console.WriteLine("AmigoDistante...");

                Console.WriteLine(amiga.InfoPublica);
                //Console.WriteLine(amiga.CorDoOlho);
                //Console.WriteLine(amiga.NumeroDoCelular);
                //Console.WriteLine(amiga.JeitoDeFalar);
                //Console.WriteLine(amiga.SegredoDeFamilia);
                //Console.WriteLine(amiga.UsaMuitoPhotoshop);
            }
        }
    }

    class Encapsulamento {
        public static void Executar() {
            SubCelebridade sub = new SubCelebridade();
            sub.MeusAcessos();

            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();

            new FilhoNaoReconhecido().MeusAcessos();
            new AmigoDistante().MeusAcessos();
        }
    }
}