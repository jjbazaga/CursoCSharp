using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Igualdade {
        public static void Executar() {
            var p1 = new Produto("A", 1.89);
            var p2 = new Produto("A", 1.89);
            var p3 = p2;

            Console.WriteLine(p1 == p2);          // diferente por referencia
            Console.WriteLine(p3 == p2);          // Iguais por referencia
            Console.WriteLine(p1.Equals(p2));     // Também iguala por referencia, 
                                                  // temos que criar em produto a compração para
                                                  // produto Equals(Object obj), para que se compare o objeto.


        }
    }
}
