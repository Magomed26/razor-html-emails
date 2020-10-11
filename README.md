# razor-html-emails
Simple ASP.NET Core web application demonstarates how to send html email using Razor templates and views

This application uses user-secrets to keep data for gmail smtp server (your email and its password). To add them to the secrets run following commands in `RazorHtmlEmailsWebApp/`

```bash
dotnet user-secrets init
dotnet user-secrets set "smtp:email" "<YOUR_EMAIL>"
dotnet user-secrets set "smtp:password" "<YOUR_PASSWORD>"
```
