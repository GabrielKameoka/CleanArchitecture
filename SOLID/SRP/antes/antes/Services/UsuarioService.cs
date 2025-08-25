using antes.Entities;

namespace antes.Services;

public class UsuarioService
{
    private static List<Usuario> _usuarios = new List<Usuario>();
    private static int _proximoId = 1;
    
    public void CadastrarUsuario(Usuario usuario)
    {
        //1: validação de dados
        if (string.IsNullOrEmpty(usuario.Nome))
            throw new ArgumentException("Nome necessário;");
        if (usuario.Idade < 0)
            throw new ArgumentException("Idade negativo");
        
        //2. lógica de negócios
        usuario.Id = _proximoId++;
        
        //3. persistência de dados 
        _usuarios.Add(usuario);

        //4. monitoramento
        Console.WriteLine($"ID:{usuario.Id}, usuário:{usuario.Nome}, idade:{usuario.Idade}");
    }
}

//Essa classe funciona direitinho, mas tem muitas responsabilidades