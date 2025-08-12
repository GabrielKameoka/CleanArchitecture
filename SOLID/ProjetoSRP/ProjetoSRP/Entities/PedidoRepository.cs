using ProjetoSRP.Banco;
using ProjetoSRP.Services;

namespace ProjetoSRP.Entities;

//só atua como intermediário entre a aplicação e o banco.
public class PedidoRepository
{
    private readonly BancoPedidos bancoPedidos;

    public PedidoRepository(BancoPedidos bancoPedidos)
    {
        this.bancoPedidos = bancoPedidos;
    }

    public void AdicionarPedido(Pedido pedido)
    {
        bancoPedidos.AdicionarPedido(pedido);
    }

    public IReadOnlyList<Pedido> ObterPedidos()
    {
        return bancoPedidos.Pedidos;
    }
}