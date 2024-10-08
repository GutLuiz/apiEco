using api.model;


namespace api.infraestrutura
{
    public class agendarepositorio : agendamentorepos
    {
        // Implementação do método Add
        public void add(agendamento agendamentoo)
        {
            using (var conexao2 = new Conexaobd())
            {
                
                    conexao2.agendamento.Add(agendamentoo);
                    conexao2.SaveChanges();
                }
               
            }

        List<agendamento> agendamentorepos.GET()
        {
            using (var conexao2 = new Conexaobd())
            {
                return conexao2.agendamento.ToList();
            }
        }
    }

        

    
    }

