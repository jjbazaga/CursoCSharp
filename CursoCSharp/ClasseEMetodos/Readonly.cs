using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class Cliente {
        public string Nome;
        public readonly DateTime Nascimento;

        public Cliente(string nome, DateTime nascimento) {
            Nome = nome;
            Nascimento = nascimento;

            //Nascimento = new DateTime(2023, 01, 17); //Aqui pode ser setado, e se manterá.
        }

        public Cliente() {
        }

        public string GetDataDeNascimento() {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, 
                Nascimento.Month, Nascimento.Year);
        }       
    }

    class Readonly {
        public static void Executar() {
            var novoCliente = new Cliente("Marta Lúcia", 
                new DateTime(1965, 9, 1));
            Console.WriteLine(novoCliente.Nome);
            Console.WriteLine(novoCliente.GetDataDeNascimento());
        }
    }
}