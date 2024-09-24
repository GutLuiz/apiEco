using api.model;
using Microsoft.EntityFrameworkCore;


namespace api.infraestrutura
{
    public class Loginrepositorio : loginrepos
    {
        public void add(login loginn)
        {
            using (var conexao = new Conexaobd())
            {
                conexao.login.Add(loginn);
                conexao.SaveChanges(); // Deixe isso sem o try-catch para ver o erro completo
            }


        }

        public List<login> GET()
        {
            using (var conexao = new Conexaobd())
            {
                return conexao.login.ToList();
            }
        }
    }
}