using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorHtmlEmailsWebApp.Services;

namespace RazorHtmlEmailsWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRegisterAccountService _registerAccountService;

        public IndexModel(IRegisterAccountService registerAccountService)
        {
            _registerAccountService = registerAccountService;
        }

        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _registerAccountService.Register("magomed260298@gmail.com", Url.Page("./Index"));
            return Page();
        }
    }
}