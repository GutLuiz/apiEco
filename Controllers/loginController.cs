using api.model;
using api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class loginController : ControllerBase
    {
        private readonly loginrepos _loginrepos;

        public loginController(loginrepos loginrepos)
        {
            _loginrepos = loginrepos ?? throw new ArgumentNullException();
        }

        // Método para adicionar (Registro)
        [HttpPost("register")]
        public IActionResult add(loginViewModel loginView)
        {
            var login = new login(loginView.email, loginView.senha);
            _loginrepos.add(login);
            return Ok();
        }

        // Método para login
        [HttpPost("login")]
        public IActionResult Login([FromBody] loginViewModel loginView)
        {
            // Busca o usuário pelo email
            var user = _loginrepos.GetByEmail(loginView.email);

            // Se o usuário não existir, retorna erro
            if (user == null)
            {
                return Unauthorized("E-mail ou senha inválidos");
            }

            // Verifica se a senha fornecida corresponde à senha do banco de dados
            if (user.senha != loginView.senha) // Lembre-se de usar hashing de senhas em produção
            {
                return Unauthorized("E-mail ou senha inválidos");
            }

            // Retorna sucesso se as credenciais estiverem corretas
            return Ok("Login realizado com sucesso");
        }

        
        // Método para obter informações (exemplo de GET):
        [HttpGet]
        public IActionResult Get()
        {
            var login = _loginrepos.GET();
            return Ok(login);
        }
    }
}
