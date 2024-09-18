using System.ComponentModel.DataAnnotations;

namespace api.model
{
    public class login
    {
        [Key]
        public int idlogin { get; set; }
        public string email { get; set; }
        public string senha { get; set; }

        public login(string email, string senha)
        {
            this.email = email ?? throw new ArgumentNullException(nameof(email));
            this.senha = senha;
        }
    }
}
