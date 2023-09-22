using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "olá".ToUpper()
                .Insert(3, " World!!!")
                .Replace("World!!!","Mundo!!!");
            Console.WriteLine(saudacao);
            Console.WriteLine("Teste".Length);

            string valorImportante = null;

            //Console.WriteLine(valorImportante.Length); está vazio não tem tamanho;
            Console.WriteLine(valorImportante?.Length); // agora vai aparecer um espaço em branco, usando ? "Nullable"
        }
    }
}