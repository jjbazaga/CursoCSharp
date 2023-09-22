using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class Moto {
        private string Marca;
        private string Modelo;
        private uint Cilindrada; //Aceita somente positivos

        public Moto(string marca, string modelo, uint cilindrada) {
            SetMarca(marca);
            SetModelo(modelo);
            SetCilindrada(cilindrada);
        }

        public Moto() {
        }

        public string GetMarca() {
            return Marca;
        }


        public void SetMarca(string marca) {
            Marca = marca;
        }

        public string GetModelo() {
            return Modelo;
        }

        public void SetModelo(string modelo) {
            Modelo = modelo;
        }

        public uint GetCilindrada() {
            return Cilindrada;
        }

        public void SetCilindrada(uint cilindrada) {
            // Primeira opção:
            //if(cilindrada >= 0) {
            //    Cilindrada = cilindrada;
            //}

            // Segunda opção:
            //Cilindrada = Math.Abs(cilindrada); // Torna a cilindrada sempre positiva.

            // Terceira Opção
            Cilindrada = cilindrada;

        }
    }

    class GetSet {
        public static void Executar() {
            var moto1 = new Moto("Kawasaki", "Ninja ZX-6R", 636);
            Console.WriteLine(moto1.GetMarca());
            Console.WriteLine(moto1.GetModelo());
            Console.WriteLine(moto1.GetCilindrada());

            var moto2 = new Moto();
            moto2.SetMarca("Honda");
            moto2.SetModelo("CG Titan");
            moto2.SetCilindrada(150);
            Console.WriteLine($"Moto {moto2.GetMarca()}" +
                $" do modelo {moto2.GetModelo()}" +
                $" com {moto2.GetCilindrada()} cilindradas.");
        }
    }
}