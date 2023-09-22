using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresDeAtribuicao {
        public static void Executar() {
            var num1 = 3;
            num1 = 7;
            num1 += 10;
            num1 -= 3;
            num1 *= 5;
            num1 /= 2;
            Console.WriteLine(num1);

            int a = 1;
            int b = a;   // copia, não referencia.
            Console.WriteLine(b);

            a++; // a = a + 1
            b--; // b = b - 1
            Console.WriteLine($"{a} {b}");
            Console.WriteLine(a++ == b--);


            // Não se preocupe com o codigo agora
            dynamic c = new System.Dynamic.ExpandoObject();
            c.nome = "João";
            Console.WriteLine(c.nome);

            dynamic d = c;
            d.nome = "Maria";
            Console.WriteLine($"{c.nome} {d.nome}"); 
        }
    }
}
