using depois.Entities;
using depois.Interfaces;

namespace depois.Implementations;

public class UsuarioRepository :  IUsuarioRepository
{
    private readonly List<Usuario> _usuarios = new List<Usuario>();
    
    public void Cadastrar(Usuario usuario)
    {
        // Simula persistência em "banco de dados"
        _usuarios.Add(usuario);
        Console.WriteLine($"Usuário {usuario.Nome} salvo no repositório");
    }
}