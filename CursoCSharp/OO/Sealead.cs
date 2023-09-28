using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    sealed class SemFilho {
        public double ValorDaFortuna() {
            return 1_407_033.65;
        }
    }

    //class SouFilho : SemFilho {      Não é possível herdar de classe sealed

    //}

    class Avo {
        public virtual bool HonrarNomeFamilia() {
            return true;
        }
    }

    class Pai : Avo {
        public override sealed bool HonrarNomeFamilia() {
            return true;
        }
    }

    //class FilhoRebelde : Pai {
    //    public override bool HonrarNomeFamilia() {         // Não consegue subscrever, está selado em Pai.
    //        return false;
    //    }
    //}

    class FilhoRebelde : Pai {
        public new bool honrarnomefamilia() {         // não consegue subscrever, está selado em pai, 
            return false;                             //mas pode ocultar o metodo de pai não subscrevendo (override)
        }
    }

    class Sealead {
        public static void Executar() {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.ValorDaFortuna());

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
