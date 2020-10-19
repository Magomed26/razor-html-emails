using System.Threading.Tasks;

namespace RazorToStringTest.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}