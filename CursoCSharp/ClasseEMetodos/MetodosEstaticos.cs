using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    public class CalculadoraEstatica {
        // Estático - diretamente pela classe
        public static int Somar(int a, int b) {
            return a + b;
        }

        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        // Não estático - instancia
        public int Subtrair(int a, int b) {
            return a - b;
        }
    }

    class MetodosEstaticos {
        public static void Executar() {
            // diretamente pela classe
            var resultado = CalculadoraEstatica.Multiplicar(2,2);
            Console.WriteLine("Resultado {0}", resultado);
            Console.WriteLine(CalculadoraEstatica.Somar(2, 2));

            // Instanciado como objeto
            CalculadoraEstatica calc = new CalculadoraEstatica();  
            Console.WriteLine(calc.Subtrair(2, 2));
        }
    }
}
