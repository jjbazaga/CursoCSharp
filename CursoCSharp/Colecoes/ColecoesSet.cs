using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {

   

    class ColecoesSet {
        public static void Executar() {
            var livro = new Produto("Game of Throne", 49.9);

            var carrinho = new HashSet<Produto>();
            carrinho.Add(livro);

            var combo = new HashSet<Produto> {
                new Produto("Camisa", 29.9),
                new Produto("8ª Temporada Game of Throne", 99.9 ),
                new Produto("Poster", 10.0),
                new Produto("Poster", 10.0)
            };

            carrinho.UnionWith(combo);

            Console.WriteLine(carrinho.Count);
            //carrinho.RemoveAt(3);

            carrinho.Add(livro);
            carrinho.Add(livro);
            carrinho.Add(livro);
            carrinho.Add(livro);

            foreach(var item in carrinho) {
                //Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }
            carrinho.Add(livro); // Não aceita repetição e não trabalha indexado.
            //Console.WriteLine(carrinho.LastIndexOf(livro)); 
        }
    }
}