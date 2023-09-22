using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Jorge";
            // nome = 123; já reconheceu como string, pois inicializada anteriormente
            Console.WriteLine(nome);
            int a; // declarada variável ou atributo
            a = 3; // atribui o valor
            int b = 2; // declara e atribui
            Console.WriteLine(a + b);
        }
    }
}