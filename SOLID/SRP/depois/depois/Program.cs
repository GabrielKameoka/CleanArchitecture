using System;
using depois.Implementations;
using depois.Interfaces;
using depois.Services;

namespace depois;

class Program
{
    public static void Main(string[] args)
    {
        IUsuarioValidator validator = new UsuarioValidator();
        IUsuarioRepository repository = new UsuarioRepository();
        UsuarioServices usuarioService = new UsuarioServices(repository, validator);
        
        try
        {
            usuarioService.CadastrarUsuario("João Silva", 25);
            usuarioService.CadastrarUsuario("Maria Santos", 30);
    
            // Isso vai falhar na validação:
            usuarioService.CadastrarUsuario("An", 5); // Nome muito curto
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}