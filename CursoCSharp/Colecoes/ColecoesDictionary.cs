using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesDictionary {
        public static void Executar() {
            var filmes = new Dictionary<int, string>();

            filmes.Add(2000, "Gladiador");
            filmes.Add(2002, "Homen-Aranha");
            filmes.Add(2004, "Os Incriveis");
            filmes.Add(2006, "O Grande Truque");
            filmes.Add(2010, "Gladiador2");

            foreach(Object obj in filmes) {
                Console.WriteLine(obj);
            }

            if (filmes.ContainsKey(2004)) {
                Console.WriteLine("2004: " + filmes[2004]);
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2006));
                Console.WriteLine("2004: " + filmes.GetValueOrDefault(2005)); // Retorna branco
                
                Console.WriteLine(filmes.ContainsValue("Amnésia"));
                Console.WriteLine($"Removeu? {filmes.Remove(2004)}");

                filmes.TryGetValue(2006, out string filme2006);
                Console.WriteLine($"Filme {filme2006}!");

                filmes.TryGetValue(2016, out string filme2016);
                Console.WriteLine($"Filme {filme2016}!");

                foreach(object obj in filmes.Keys) {
                    Console.WriteLine(obj);
                }

                foreach(object obj in filmes.Values) {
                    Console.WriteLine(obj);
                }

                foreach (KeyValuePair<int, string> obj in filmes) {
                    Console.WriteLine($"{obj.Value} é de {obj.Key}.");
                }
            }
        }
    }
}