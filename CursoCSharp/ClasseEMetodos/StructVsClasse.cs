using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public struct SPonto {
        public int x;
        public int y;

        public SPonto(int x, int y) {
            this.x = x;
            this.y = y;
        }
    }

    public class CPonto {
        public int x;
        public int y;

       
    }

    class StructVsClasse {
        public static void Executar() {

            Console.WriteLine("Cópia por valor - Struct");
            //SPonto ponto;
            //ponto.x = 10;
            //ponto.y = 0;    ou
            SPonto ponto1 = new SPonto { x = 10, y = 3 };
            SPonto copiaPonto1 = ponto1;
            Console.WriteLine($"Ponto 1: {ponto1.x} | copiaPonto1: {copiaPonto1.x}");
            // Atribuição, ou copia por valor. (Struct) memória stack
            ponto1.x = 15;
            Console.WriteLine($"Ponto 1: {ponto1.x} | " +
                $"copiaPonto1: {copiaPonto1.x}"); 

            Console.WriteLine();
            Console.WriteLine("Cópia por referência - Classe");
            CPonto ponto2 = new CPonto { x = 18, y = 21 };
            CPonto copiaPonto2 = ponto2;
            Console.WriteLine($"Ponto2: {ponto2.x} | copiaPonto2: {copiaPonto2.x}");
            // Atribuição, ou copia por referência memória Heap
            ponto2.x = 28;
            Console.WriteLine($"Ponto2: {ponto2.x} | copiaPonto2: {copiaPonto2.x}"); 
        }
    }
}