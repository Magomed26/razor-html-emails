namespace RazorHtmlEmailsWebApp.Views.Emails.ConfirmAccount
{
    public class ConfirmAccountViewModel
    {
        public string ConfirmAccountUrl { get; set; }

        public ConfirmAccountViewModel(string confirmAccountUrl)
        {
            ConfirmAccountUrl = confirmAccountUrl;
        }
    }
}