using System.Threading.Tasks;

namespace RazorHtmlEmailsWebApp.Services
{
    public interface IRazorViewToStringRenderer
    {
        Task<string> RenderViewToStringAsync<TModel>(string viewName, TModel model);
    }
}