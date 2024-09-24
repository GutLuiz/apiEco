using api.model;
using api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/v1/login")]
    public class loginController : ControllerBase
    {
        private readonly loginrepos _loginrepos;

        public loginController(loginrepos loginrepos)
        {
            _loginrepos = loginrepos ?? throw new ArgumentNullException();
        }

        // Metodo para adicionar:
        [HttpPost]
        public IActionResult add(loginViewModel loginView)
        {
            var login = new login(loginView.email, loginView.senha);
            _loginrepos.add(login);
            return Ok();
        }

        //Metodo para obter uma informação:
        [HttpGet]
        public IActionResult Get()
        {
            var login = _loginrepos.GET();

            return Ok(login);
        }


    }
}