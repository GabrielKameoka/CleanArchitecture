using depois.Entities;
using depois.Interfaces;

namespace depois.Services;

public class UsuarioValidator :  IUsuarioValidator
{
    public void Validar(Usuario usuario)
    {
        if (string.IsNullOrWhiteSpace(usuario.Nome))
            throw new ArgumentException("Nome é obrigatório");
        
        if (usuario.Nome.Length < 3)
            throw new ArgumentException("Nome deve ter pelo menos 3 caracteres");
        
        if (usuario.Idade < 0)
            throw new ArgumentException("Idade não pode ser negativa");
        
        if (usuario.Idade > 150)
            throw new ArgumentException("Idade inválida");
    }
}