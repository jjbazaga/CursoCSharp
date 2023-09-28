using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public abstract class Celular {
        public abstract string Assistente();

        public virtual string Tocar() {
            return "Trim trim trim...";
        }
    }

    public class Samsung : Celular {
        public override string Assistente() {
            return "Olá meu nome é Bixby!";
        }
    }

    public class Iphone : Celular {
        public override string Assistente() {
            return "Olá meu nome é Siri!";
        }
    }


    class Abstract {
        public static void Executar() {
            Celular c1 = new Samsung();
            //Console.WriteLine(c1.Assistente());
            //Console.WriteLine(c1.Tocar());

            var c2 = new Iphone();
            //Console.WriteLine(c2.Assistente());
            //Console.WriteLine(c2.Tocar());
            //Console.WriteLine();

            var celulares = new List<Celular> {
                new Iphone(),
                new Samsung()
            };

            foreach(var obj in celulares) {
                Console.WriteLine(obj.Assistente());
                Console.WriteLine(obj.Tocar());
            }
        }
    }
}
