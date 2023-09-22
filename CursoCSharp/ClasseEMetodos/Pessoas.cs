namespace CursoCSharp.ClasseEMetodos {
    class Pessoas {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Apresentar() {
            return string.Format(
                $"Olá me chamo {Nome} e tenho {Idade} anos.");
            }
    }
}