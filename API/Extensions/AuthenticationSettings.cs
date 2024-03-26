namespace API.Extensions
{
    public class AuthenticationSettings
    {
        public string EncryptionKey { get; } = "WhisperingThunderstorms";
        public int ExpirationTime { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }

    }
}
