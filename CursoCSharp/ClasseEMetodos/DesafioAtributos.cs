using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class DesafioAtributos {

        int a = 10;
        double b = 3.1415;

        public static void Executar() {
            DesafioAtributos variavel1 = new DesafioAtributos();
            Console.WriteLine(variavel1.a);
            var variavel2 = new DesafioAtributos();
            Console.WriteLine(variavel2.b);
        }
    }
}