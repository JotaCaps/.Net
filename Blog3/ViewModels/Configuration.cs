namespace Blog3
{
    public static class Configuration
    {
        // TOKEN - JWT - Json Web Token
        public static string JwtKey { get; set; } = "fj399fmaslsdjfnddeaithvclvcne";

        public static SmtpConfiguration Smtp = new();

        public class SmtpConfiguration
        {
            public string Host { get; set; }
            public int Port { get; set; } = 25;
            public string UserName { get; set; }
            public string Password { get; set; }
        }

    }
}