using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class Dependente {
        public string Nome;
        public int Idade;

        public override string ToString() {
            return $"Nome: {Nome}, Idade: {Idade} ";
        }
    }

    class ValorVsReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumero = numero;
            Console.WriteLine($"Numero: {numero} | Copia: {copiaNumero}");
            numero++;
            Console.WriteLine($"Numero: {numero} | Copia: {copiaNumero}");

            Dependente dep = new Dependente { Nome = "Beto", Idade = 68 };
            Dependente copiaDep = dep;
            Console.WriteLine(dep);
            Console.WriteLine(copiaDep);

            Console.WriteLine();
            dep.Nome = "Marina";
            copiaDep.Idade = 43;
            Console.WriteLine(dep);
            Console.WriteLine(copiaDep); // Aponta para o mesmo objeto que dep
        }
    }
}