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

        
        [HttpPost("register")]
        public IActionResult add(loginViewModel loginView)
        {
            var login = new login(loginView.email, loginView.senha);
            _loginrepos.add(login);
            return Ok();
        }

       
        [HttpPost("login")]
        public IActionResult Login([FromBody] loginViewModel loginView)
        {
            
            var user = _loginrepos.GetByEmail(loginView.email);

            
            if (user == null)
            {
                return Unauthorized("E-mail ou senha inválidos");
            }

            
            if (user.senha != loginView.senha) 
            {
                return Unauthorized("E-mail ou senha inválidos");
            }

          
            return Ok(new
            {
                status = "success",
                email = user.email 
            });
        }


        [HttpGet]
        public IActionResult Get()
        {
            var login = _loginrepos.GET();
            return Ok(login);
        }
    }
}
