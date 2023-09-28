using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Animal {
        public string Nome { get; set; }

        // Construtor da classe pai, quando chamado devolve para o construtor que chamou
        public Animal(string nome) {
            Nome = nome;
        }
    }

    public class Cachorro : Animal {
        public double Altura { get; set; }

        // Chamando o nome do construtor base, da classe pai. Depois recebe de volta
        public Cachorro(string nome) : base(nome) {
            Console.WriteLine($"Cachorro {nome} foi inicializado");
        }

        // Chamando o nome do construtor local(this), 
        // que recebeu de volta da propria classe
        // Também pode receber diretamente da classe pai - base(nome).
        // Neste caso não passa pelo construtor herdado de pai
        public Cachorro(string nome, double altura) : this(nome) {
            Altura = altura;
        }

        public override string ToString() {
            return $"{Nome} tem {Altura.ToString("f1")}cm de altura!";
        }
    }

    class ConstrutorThis {
        public static void Executar() {
            Cachorro spike = new Cachorro("Spike");
            var max = new Cachorro("Max", 40.0);

            Console.WriteLine(spike);
            Console.WriteLine(max);
        }
    }
}
