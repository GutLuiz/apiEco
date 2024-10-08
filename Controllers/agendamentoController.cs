using api.model;
using api.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/v1")]
    public class AgendamentoController : ControllerBase
    {
        private readonly agendamentorepos _agendamentoRepos;

        public AgendamentoController(agendamentorepos agendamentorepos)
        {
            _agendamentoRepos = agendamentorepos ?? throw new ArgumentException();
        }

        // Método para fazer o agendamento:
        [HttpPost("agendamento")]
        public IActionResult Add(agendamentoViewModel agendamentoView)
        {
            DateTime dataHoraUtc = DateTime.SpecifyKind(agendamentoView.data_hora, DateTimeKind.Utc);
            var agendamento = new agendamento(agendamentoView.nome, agendamentoView.modelo, agendamentoView.placa, dataHoraUtc );
            _agendamentoRepos.add(agendamento);
            return Ok();         
        }

        [HttpGet]
        public IActionResult Get()
        {
            var agendamento = _agendamentoRepos.GET();
            return Ok(agendamento);
        }

    }
}
