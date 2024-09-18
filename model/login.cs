using System.ComponentModel.DataAnnotations;

namespace api.model
{
    public class login 
    {
        [Key]
        public int idlogin { get; private set; }
        public string email { get; private set; }

        public string senha { get; private set; }

        public login (string email, string senha)
        {
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.senha = senha;
        }
    }
}
