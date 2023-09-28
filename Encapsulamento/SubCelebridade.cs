using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulamento {
    public class SubCelebridade {
        // Todos
        public string InfoPublica = "Tenho um istagram!"; //Pode ser acessado por todos os projetos e classes

        // Herança
        protected string CordoOlho = "Verde"; //Pode ser acessado por herança de subcelebridade

        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5561999443613;

        // Herança ou mesmo projeto (assembly)
        protected internal string JeitoDeFalar = "Uso muitas gírias"; //Dentro do mesmo projeto e mesma herença - 
        //mesmo assembly

        // Mesma classe ou heramça no mesmo projeto (c# >= 7.2)
        private protected string SegredoFamilia = "Blá blá ..."; //

        // Private é o padrão, dentro da própria classe
        bool UsaMuitoPhotoshop = true;

        public void MeusAcessos() {
            Console.WriteLine("Subcelebridade...");

            Console.WriteLine(InfoPublica);
            Console.WriteLine(CordoOlho);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitoDeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(UsaMuitoPhotoshop);
            Console.WriteLine();
        }
    }
}
