using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAD
{
    public class ItemMenu
    {
        private string nome;
        private decimal preco;

        public ItemMenu(string nome, decimal preco)
        {
            this.nome = nome;
            this.preco = preco;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine($"Item: {nome} | Preço: R${preco:F2}");
        }
    }
}