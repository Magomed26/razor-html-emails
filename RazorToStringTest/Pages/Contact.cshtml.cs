using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorToStringTest.Services;

namespace RazorToStringTest.Pages
{
    public class ContactModel : PageModel
    {
        private readonly IEmailSender _emailSender;
        private readonly IRazorPartialToStringRenderer _renderer;

        public ContactModel(IEmailSender emailSender, IRazorPartialToStringRenderer razorPartialToStringRenderer)
        {
            _emailSender = emailSender;
            _renderer = razorPartialToStringRenderer;
        }
        
        [BindProperty]
        public ContactForm ContactForm { get; set; }

        [TempData]
        public string PostResult { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            var body = await _renderer.RenderPartialToStringAsync("Emails/ContactEmailPartial", ContactForm);
            await _emailSender.SendEmailAsync(ContactForm.Email, ContactForm.Subject, body);
            PostResult = "Check your specified pickup directory";
            return RedirectToPage();
        }
    }
    public class ContactForm
    {
        public string Email { get; set; }
        public string Message { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public Priority Priority { get; set; }
    }
    public enum Priority
    {
        Low, Medium, High
    }
}
