using System;
using System.Threading.Tasks;
using RazorHtmlEmailsWebApp.Views.Emails.ConfirmAccount;

namespace RazorHtmlEmailsWebApp.Services
{
    public class RegisterAccountService : IRegisterAccountService
    {
        private readonly IRazorViewToStringRenderer _razorViewToStringRenderer;
        private readonly IEmailSender _emailSender;

        public RegisterAccountService(IRazorViewToStringRenderer razorViewToStringRenderer, IEmailSender emailSender)
        {
            _razorViewToStringRenderer = razorViewToStringRenderer;
            _emailSender = emailSender;
        }

        public async Task Register(string email, string baseUrl)
        {
            var confirmAccountModel = new ConfirmAccountViewModel($"{baseUrl}/{Guid.NewGuid()}");
            var htmlMessageBody = await _razorViewToStringRenderer.RenderViewToStringAsync(
                "/Views/Emails/ConfirmAccount/ConfirmAccount.cshtml", confirmAccountModel);
            var toAddress = email;
            await _emailSender.SendEmailAsync(email, "Confirm your account", htmlMessageBody);
        }
    }
}