using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    public class Produto {
        public string Nome;
        public double Preco;
        public static double Desconto = 0.1;

        public Produto(string nome, double preco, double desconto) {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto() {
        }

        public double CalcularDesconto() {
            return Preco - Preco * Desconto;
        }
    }


    class AtributosEstaticos {
        public static void Executar() {
            var produto1 = new Produto ("Path Scan", 270.0, 1.0);
            var produto2 = new Produto ("Caneta", 3.2, 0.8);
            var produto3 = new Produto() {
                Nome = "Borracha",
                Preco = 5.3,
               // Desconto = 0.5 - atributo estatico associado a classe.
            };
            Produto.Desconto = 0.05;

            Console.WriteLine(produto1.CalcularDesconto());
            Console.WriteLine(produto2.CalcularDesconto());
            Console.WriteLine(produto3.CalcularDesconto());

        }
    }
}
