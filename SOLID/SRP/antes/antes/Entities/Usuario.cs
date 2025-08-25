namespace antes.Entities;

public class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Usuario(string nome, int idade)
    {
        Nome = nome;
        Idade = idade;
    }
}