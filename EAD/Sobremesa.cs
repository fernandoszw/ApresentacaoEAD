using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD
{
    public class Sobremesa : ItemMenu
    {
        public bool ContemAcucar { get; set; }
        public string Sabor { get; set; }

        public Sobremesa(string nome, decimal preco, bool contemAcucar, string sabor)
            : base(nome, preco)
        {
            ContemAcucar = contemAcucar;
            Sabor = sabor;
        }

        public override void MostrarDetalhes()
        {
            string tipo = ContemAcucar ? "Contém açúcar" : "Sem açúcar";
            Console.WriteLine($"Sobremesa: {Nome} | Preço: R${Preco:F2} | Sabor: {Sabor} | {tipo}");
        }
    }
}