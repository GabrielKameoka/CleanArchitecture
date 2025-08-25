using depois.Entities;
using depois.Interfaces;

namespace depois.Services;

public class UsuarioServices
{
    private readonly IUsuarioRepository _usuarioRepository;
    private readonly IUsuarioValidator _usuarioValidator;
    private int _proximoId = 1;

    // Injeção de dependências pelo construtor
    public UsuarioServices(IUsuarioRepository usuarioRepository, IUsuarioValidator usuarioValidator)
    {
        _usuarioRepository = usuarioRepository;
        _usuarioValidator = usuarioValidator;
    }

    public void CadastrarUsuario(string nome, int idade)
    {
        // Cria o usuário
        var usuario = new Usuario(nome, idade);
        
        // Atribui o ID (responsabilidade do Service)
        usuario.Id = _proximoId++;
        
        // Valida o usuário (delega para o Validator)
        _usuarioValidator.Validar(usuario);
        
        // Salva o usuário (delega para o Repository)
        _usuarioRepository.Cadastrar(usuario);
        
        Console.WriteLine($"Usuário:{usuario.Nome}, cadastrado com ID:{usuario.Id} no banco de dados");
    }
}