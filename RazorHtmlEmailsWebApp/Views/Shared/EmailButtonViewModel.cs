namespace RazorHtmlEmailsWebApp.Views.Shared
{
    public class EmailButtonViewModel
    {
        public string Url { get; set; }
        public string Text { get; set; }

        public EmailButtonViewModel(string url, string text)
        {
            Url = url;
            Text = text;
        }
    }
}