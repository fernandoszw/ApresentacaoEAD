using EAD;
using System;

var prato1 = new Prato("Lasanha de Berinjela", 35.90m, true, "Berinjela, queijo, molho de tomate");
var bebida1 = new Bebida("Suco de Laranja", 8.50m, false, 300);
var sobremesa1 = new Sobremesa("Mousse de Chocolate", 15.00m, true, "Chocolate");

// Criar pedido
var pedido = new Pedido(1, "Fernando Souza");

// Adicionar itens ao pedido
pedido.AdicionarPrato(prato1);
pedido.AdicionarBebida(bebida1);
pedido.AdicionarSobremesa(sobremesa1);

// Mostrar pedido e total
pedido.ExibirPedido();

// Salvar pedido em JSON
pedido.SalvarPedidoJson();