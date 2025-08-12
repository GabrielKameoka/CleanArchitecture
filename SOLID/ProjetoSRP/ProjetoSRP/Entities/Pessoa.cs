using System.ComponentModel.DataAnnotations;

namespace ProjetoSRP.Entities;

public class Pessoa
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string CPF { get; set; }

    public Pessoa(string nome, string email, string cpf)
    {
        Nome = nome;
        Email = email;
        CPF = cpf;
    }
}