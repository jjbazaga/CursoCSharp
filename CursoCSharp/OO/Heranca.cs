using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Carro {
        protected readonly int VelocidadeMaxima;
        private int VelocidadeAtual;

        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0) {
                VelocidadeAtual = 0;
            } else if (novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;
        }

        public virtual int Acelerar() {
            return AlterarVelocidade(5);
        }

        public int Frear() {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro {
        public Uno() : base(200) {
        }

        override
        public int Acelerar() {
            return AlterarVelocidade(15);
        }

        // Ocultando o método da classe pai
        public new int Frear() {
            return AlterarVelocidade(-15);
        }
    }

    public class Ferrari : Carro {
        public Ferrari() : base(350) {
        }

        override
        public int Acelerar() {
            return AlterarVelocidade(30);
        }

        // Ocultando o método da classe pai
        public new int Frear() {
            return AlterarVelocidade(-30);
        }

    }

    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno uno1 = new Uno();
            Console.WriteLine(uno1.Acelerar());
            Console.WriteLine(uno1.Acelerar());
            Console.WriteLine(uno1.Acelerar());
            Console.WriteLine(uno1.Frear());
            Console.WriteLine(uno1.Frear());
            Console.WriteLine(uno1.Frear());
            Console.WriteLine();

            Console.WriteLine("Ferrari...");
            Ferrari fer1 = new Ferrari();
            Console.WriteLine(fer1.Acelerar());
            Console.WriteLine(fer1.Acelerar());
            Console.WriteLine(fer1.Acelerar());
            Console.WriteLine(fer1.Frear());
            Console.WriteLine(fer1.Frear());
            Console.WriteLine(fer1.Frear());
            Console.WriteLine();

            Console.WriteLine("Uno2...");
            Carro uno2 = new Uno();
            Console.WriteLine(uno2.Acelerar());
            Console.WriteLine(uno2.Acelerar());
            Console.WriteLine(uno2.Frear());
            Console.WriteLine(uno2.Frear());
            Console.WriteLine(uno2.Frear());
            Console.WriteLine();

            Console.WriteLine("Ferrari2...");
            Carro fer2 = new Ferrari();
            Console.WriteLine(fer2.Acelerar());
            Console.WriteLine(fer2.Acelerar());
            Console.WriteLine(fer2.Frear());
            Console.WriteLine(fer2.Frear());
            Console.WriteLine(fer2.Frear());
            Console.WriteLine();

            fer2 = new Uno();  // Polimorfismo Ferrari assumindo Uno
            Console.WriteLine(fer2.Acelerar());
            Console.WriteLine(fer2.Acelerar());
            Console.WriteLine(fer2.Frear());
            Console.WriteLine(fer2.Frear());
            Console.WriteLine(fer2.Frear());
            Console.WriteLine();
        }
    }
}