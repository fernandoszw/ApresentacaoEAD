using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD
{
    public class Prato : ItemMenu
    {
        public bool Vegetariano { get; set; }
        public string IngredientesPrincipais { get; set; }

        public Prato(string nome, decimal preco, bool vegetariano, string ingredientesPrincipais)
            : base(nome, preco)
        {
            Vegetariano = vegetariano;
            IngredientesPrincipais = ingredientesPrincipais;
        }

        public override void MostrarDetalhes()
        {
            string tipo = Vegetariano ? "Vegetariano" : "Não vegetariano";
            Console.WriteLine($"Prato: {Nome} | Preço: R${Preco:F2} | Tipo: {tipo} | Ingredientes: {IngredientesPrincipais}");
        }
    }
}