using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Carro {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public string Apresentar() {
            return string.Format($"Modelo {Modelo}, fabricação {Fabricante}, produzido em {Ano}");
        }

        public Carro() {
        }

        public Carro(string modelo, string fabricante, int ano) {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
    }

    class Construtores {
        public static void Executar() {

            Carro carro1 = new Carro();

            carro1.Modelo = "Uno Mille";
            carro1.Fabricante = "Fiat";
            carro1.Ano = 2011;
            Carro carro2 = new Carro("Civic", "Honda", 2018);
            Carro carro3 = new Carro() { Modelo = "325i", Fabricante = "BMW", Ano = 2019 };

            Console.WriteLine(
                $"Modelo {carro1.Modelo},fabricação {carro1.Fabricante}, produzido em {carro1.Ano }.");
            Console.WriteLine(carro2.Apresentar().ToUpper());
            Console.WriteLine(carro3.Apresentar().ToUpper());
        }
    }
}