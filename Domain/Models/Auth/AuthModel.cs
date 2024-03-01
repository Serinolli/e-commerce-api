namespace Domain.Models.Auth 
{
    public class AuthModel(string email, string password) 
    {
        public string Email { get; set; } = email;
        public string Password { get; set; } = password;

    }
}