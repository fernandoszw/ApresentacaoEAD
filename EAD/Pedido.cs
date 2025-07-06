using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace EAD
{
    public class Pedido 
    {
        public int NumeroMesa { get; set; }
        public string NomeCliente { get; set; }

        public List<Prato> Pratos { get; private set; } = new List<Prato>();
        public List<Bebida> Bebidas { get; private set; } = new List<Bebida>();
        public List<Sobremesa> Sobremesas { get; private set; } = new List<Sobremesa>();

        public Pedido(int numeroMesa, string nomeCliente)
        {
            NumeroMesa = numeroMesa;
            NomeCliente = nomeCliente;
        }

        public void AdicionarPrato(Prato prato)
        {
            Pratos.Add(prato);
        }

        public void AdicionarBebida(Bebida bebida)
        {
            Bebidas.Add(bebida);
        }

        public void AdicionarSobremesa(Sobremesa sobremesa)
        {
            Sobremesas.Add(sobremesa);
        }

        public decimal CalcularTotal()
        {
            decimal total = 0m;
            foreach (var p in Pratos)
                total += p.Preco;
            foreach (var b in Bebidas)
                total += b.Preco;
            foreach (var s in Sobremesas)
                total += s.Preco;
            return total;
        }

        public void ExibirPedido()
        {
            Console.WriteLine($"Mesa {NumeroMesa} - Cliente: {NomeCliente}\n");

            Console.WriteLine("Pratos:");
            if (Pratos.Count == 0) Console.WriteLine("  Nenhum prato");
            else foreach (var p in Pratos) Console.WriteLine($"  - {p.Nome} (R${p.Preco:F2})");

            Console.WriteLine("Bebidas:");
            if (Bebidas.Count == 0) Console.WriteLine("  Nenhuma bebida");
            else foreach (var b in Bebidas) Console.WriteLine($"  - {b.Nome} (R${b.Preco:F2})");

            Console.WriteLine("Sobremesas:");
            if (Sobremesas.Count == 0) Console.WriteLine("  Nenhuma sobremesa");
            else foreach (var s in Sobremesas) Console.WriteLine($"  - {s.Nome} (R${s.Preco:F2})");

            Console.WriteLine($"\nTotal: R${CalcularTotal():F2}");
        }

        public void SalvarPedidoJson()
        {
            string pasta = "Pedidos";
            if (!Directory.Exists(pasta))
                Directory.CreateDirectory(pasta);

            string nomeArquivo = $"Mesa{NumeroMesa}_{NomeCliente.Replace(" ", "_")}.json";
            string caminho = Path.Combine(pasta, nomeArquivo);
            var json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(caminho, json);

            Console.WriteLine($"\nPedido salvo em: {caminho}");
            Console.WriteLine($"\nPedido salvo em: {caminho}");
        }
    }
}