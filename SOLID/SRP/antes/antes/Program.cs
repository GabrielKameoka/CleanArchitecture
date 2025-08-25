using System;
using antes.Entities;
using antes.Services;

namespace antes;

public class Program
{
    public static void Main(string[] args)
    {
        var usuarioService = new UsuarioService();

        var usuario1 = new Usuario("Gabriel", 21);
        var usuario2 = new Usuario("Gabriella", 20);
        
        usuarioService.CadastrarUsuario(usuario1);
        usuarioService.CadastrarUsuario(usuario2);
    }
}