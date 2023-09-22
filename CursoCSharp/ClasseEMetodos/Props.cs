using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;
        string nome { get; set; } // Auto-implementação de propriedade
        public string Nome {

            // Implementando de forma tradicional {get} e {set}
            //get {
            //    return $"Opcional: {nome}";
            //}
            //set {
            //    nome = value;
            //}

            // Auto Implemtando {get} e {set} - props
            get => $"Opcional: {nome}"; // Lambda
            set => nome = value;

        }

        // Propriedade auto-implemenmtada, tanto (get) quanto (set)
        public double Preco { get; set; }

        // Somente para leitura (get)
        public double PrecoComDesconto {
            get => Preco * (1 - desconto);
        }

        public CarroOpcional(string nome, double preco) {
            this.nome = nome;
            Preco = preco;
        }

        public CarroOpcional() {
        }
    }

    class Props {
        public static void Executar() {

            var op1 = new CarroOpcional("Multi-midia", 5680.90);
            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = "Ar Condicionado";
            op2.Preco = 12300.0;
            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
        }

    }
}