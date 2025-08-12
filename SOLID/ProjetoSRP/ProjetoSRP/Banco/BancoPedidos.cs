using ProjetoSRP.Services;
using System.Collections.Generic;

namespace ProjetoSRP.Banco;

//só armazena os pedidos (simulando o banco de dados).
public class BancoPedidos
{
    private readonly List<Pedido> pedidos = new List<Pedido>();

    public IReadOnlyList<Pedido> Pedidos => pedidos.AsReadOnly();

    public void AdicionarPedido(Pedido pedido)
    {
        pedidos.Add(pedido);
    }
}