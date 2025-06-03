namespace CityInfo.API.Services
{
    public class LocalMailService : IMailService
    {
        private String _mailTo = "admin@mycompany.com";
        private String _mailFrom = "noreply@mycompany.com";

        public void Send(String subject, String message)
        {
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, with {nameof(LocalMailService)}.");
            Console.WriteLine($"Subject : {subject}");
            Console.WriteLine($"Message : {message}");
        }
    }
}
