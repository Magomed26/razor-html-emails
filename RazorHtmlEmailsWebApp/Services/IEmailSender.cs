using System.Threading.Tasks;

namespace RazorHtmlEmailsWebApp.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string htmlMessage);
    }
}