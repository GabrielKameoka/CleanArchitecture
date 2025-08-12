using ProjetoSRP.Entities;

namespace ProjetoSRP.Services;

//só gerencia produtos e calcula total do pedido.
public class Pedido
{
    private readonly List<Produto> produtos = new List<Produto>();

    public void AdicionarProduto(Produto produto)
    {
        produtos.Add(produto);
    }

    public decimal CalculaTotal()
    {
        decimal total = 0;

        foreach (var produto in produtos)
        {
            total += produto.Preco;
        }

        return total;
    }

    public void MostrarPedido()
    {
        foreach (var produto in produtos)
        {
            Console.WriteLine(produto);
        }
    }

    public IReadOnlyList<Produto> Produtos => produtos.AsReadOnly();
}