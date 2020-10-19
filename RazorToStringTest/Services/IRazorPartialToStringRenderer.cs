using System.Threading.Tasks;

namespace RazorToStringTest.Services
{
    public interface IRazorPartialToStringRenderer
    {
         Task<string> RenderPartialToStringAsync<TModel>(string partialName, TModel model);
    }
}