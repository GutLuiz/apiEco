using api.model;

namespace api.infraestrutura
{
    public class Loginrepositorio : loginrepos
    {
        private readonly Conexaobd conexao = new Conexaobd();
        public void add(login loginn)
        {
            conexao.logins.Add(loginn);
            //conexao.SaveChanges();
        }

        public List<login> GET()
        {
            return conexao.logins.ToList();
        }
    }
}
