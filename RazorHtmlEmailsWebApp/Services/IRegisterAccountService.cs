using System.Threading.Tasks;

namespace RazorHtmlEmailsWebApp.Services
{
    public interface IRegisterAccountService
    {
        Task Register(string email, string baseUrl);
    }
}