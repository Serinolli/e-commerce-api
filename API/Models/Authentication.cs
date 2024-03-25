using System.ComponentModel.DataAnnotations;

namespace API.Models
{
    public class Authentication
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public Authentication(string email, string password)
        {
            Email = email;
            Password = password;
        }
    }
}
