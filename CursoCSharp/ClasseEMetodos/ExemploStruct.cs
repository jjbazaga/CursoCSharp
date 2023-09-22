using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta);
    }

       struct Coordenada: Ponto {
        public int x;
        public int y;

        public Coordenada(int x, int y) {
            this.x = x;
            this.y = y;
        }
         public void MoverNaDiagonal(int delta) {
            x += delta;
            y += delta;
        }
    }

    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;
            coordenadaInicial.x = 2;
            coordenadaInicial.y = 2;

            Console.WriteLine("Coordenada Inicial: ");
            Console.WriteLine("X = {0}", coordenadaInicial.x);
            Console.WriteLine("Y = {0}", coordenadaInicial.y);

            var coordenadaFinal = new Coordenada(x: 9, y: 1);
            coordenadaFinal.MoverNaDiagonal(10);

            Console.WriteLine("Coordenada Final: ");
            Console.WriteLine("X = {0}", coordenadaFinal.x);
            Console.WriteLine("Y = {0}", coordenadaFinal.y);
        }
    }
}
