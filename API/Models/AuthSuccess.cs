namespace API.Models
{
    public class AuthSuccess
    {
        public string Token { get; set; }
        public double ExpirationTime { get; set; }

        public AuthSuccess(string token, double expirationTime) 
        {
            Token = token;
            ExpirationTime = expirationTime;
        }
    }
}
