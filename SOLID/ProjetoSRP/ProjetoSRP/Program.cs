using System;
using ProjetoSRP.Banco;
using ProjetoSRP.Entities;
using ProjetoSRP.Services;

namespace ProjetoSRP;

class Program
{
    public static void Main(string[] args)
    {
        Pessoa pessoa1 = new Pessoa("Gabriella", "gabriella@gmail.com", "12345678910");
        BancoPedidos banco = new BancoPedidos();
        PedidoRepository pedidoRepo = new PedidoRepository(banco);
        Pedido pedido = new Pedido();
        
        Console.WriteLine($"Nome: {pessoa1.Nome};");
        Console.WriteLine($"Email: {pessoa1.Email};");
        Console.WriteLine($"CPF: {pessoa1.CPF};");

        Produto p1 = new Produto("TV", 1000);
        Produto p2 = new Produto("Celular", 900);

        pedido.AdicionarProduto(p1);
        pedido.AdicionarProduto(p2);

        foreach (var produto in pedido.Produtos)
        {
            Console.WriteLine($"Produto: {produto.NomeProduto}, Preço: {produto.Preco} ");
        }
        
        Console.WriteLine($"Total do pedido: R$ {pedido.CalculaTotal()}");

        pedidoRepo.AdicionarPedido(pedido);

        Console.WriteLine($"Pedidos no banco: {pedidoRepo.ObterPedidos()}");
    }
}