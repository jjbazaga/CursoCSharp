using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // área da circunferência
            const double PI = 3.1415;
            double raio = 5.5;
            double area = PI * Math.Pow(raio, 2);        
            Console.WriteLine("Area: " + area);

            bool estaChovendoSim = true;
            bool estaChovendoNao = false;
            Console.WriteLine("Está chovendo Sim: " + estaChovendoSim);
            Console.WriteLine("Está chovendo Nao: " + estaChovendoNao);
            Console.WriteLine("Minimo byte: " + byte.MinValue);             
            Console.WriteLine("Máximo byte: " + byte.MaxValue);
            Console.WriteLine("Minimo sbyte: " + sbyte.MinValue);
            Console.WriteLine("Máximo sbyte: " + sbyte.MaxValue);
            Console.WriteLine("Minimo short: " + short.MinValue);
            Console.WriteLine("Máximo short: " + short.MaxValue);
            Console.WriteLine("Minimo inteiro: " + int.MinValue);
            Console.WriteLine("Máximo inteiro: " + int.MaxValue);
            Console.WriteLine("Minimo long: " + long.MinValue);
            Console.WriteLine("Máximo long: " + long.MaxValue);
            Console.WriteLine("Minimo double: " + double.MinValue);
            Console.WriteLine("Máximo double: " + double.MinValue);          
        }
    }
}
