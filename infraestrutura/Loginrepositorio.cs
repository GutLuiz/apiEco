using api.model;
using Microsoft.EntityFrameworkCore;


namespace api.infraestrutura
{
    public class loginrepositorio :loginrepos 
    {
        public void add(login loginn)
        {
            using (var conexao = new Conexaobd())
            {
                conexao.login.Add(loginn);
                conexao.SaveChanges(); 
            }


        }
        
        public List<login> GET()
        {
            using (var conexao = new Conexaobd())
            {
                return conexao.login.ToList();
            }
        }
        

        public login GetByEmail(string email)
        {
            using (var conexao = new Conexaobd())
            {
                return conexao.login.FirstOrDefault(u => u.email == email);
            }
        }

    }
}