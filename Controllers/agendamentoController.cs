using api.model;
using api.ViewModel;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class agendamentoController : ControllerBase
    {

        private readonly agendamentorepos _agendamentorepos;

        public agendamentoController(agendamentorepos agendamentorepos)
        {
            _agendamentorepos = agendamentorepos;
        }

        //Metodo para fazer o agendamento:
        [HttpPost("Agendamento")]

        public IActionResult add(agendamentoViewModel agendamentoViewModel)
        {
            var agendamento = new agendamento(agendamentoViewModel.nome, agendamentoViewModel.modelo_carro, agendamentoViewModel.placa_carro, agendamentoViewModel.data_hora);
            _agendamentorepos.add(agendamento);
            return Ok();
        }

        
      
    }
}
