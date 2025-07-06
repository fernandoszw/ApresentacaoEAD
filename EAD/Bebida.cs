using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD
{
    public class Bebida : ItemMenu
    {
        public bool Alcoolica { get; set; }
        public int Ml { get; set; }

        public Bebida(string nome, decimal preco, bool alcoolica, int ml)
            : base(nome, preco)
        {
            Alcoolica = alcoolica;
            Ml = ml;
        }

        public override void MostrarDetalhes()
        {
            string tipo = Alcoolica ? "Alcoólica" : "Não alcoólica";
            Console.WriteLine($"Bebida: {Nome} | Preço: R${Preco:F2} | Tipo: {tipo} | Volume: {Ml}ml");
        }
    }
}