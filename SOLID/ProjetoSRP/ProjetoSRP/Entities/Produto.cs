namespace ProjetoSRP.Entities;

public class Produto
{
    public string NomeProduto { get; set; }
    public decimal Preco { get; set; }

    public Produto(string nomeProduto, decimal preco)
    {
        NomeProduto = nomeProduto;
        Preco = preco;
    }
}