using api.model;

namespace api.infraestrutura
{
    public class agendaRepositorio : agendamentorepos

    {

        public void add(agendamento agenda)
        {
            using (var conexao2 = new Conexaobd())
            {
                conexao2.agendamento.Add(agenda);
                conexao2.SaveChanges();
            }
        }

        public List<agendamento> GET()
        {
            using (var conexao2 = new Conexaobd())
            {
                return conexao2.agendamento.ToList();
            }
        }

    }
}
