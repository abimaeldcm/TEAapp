using System.Net.Mail;
using System.Net;

namespace TEAapp.Helper.Email
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<bool> EnviarEmail(string email, string assunto, string messagem)
        {
            try
            {
                var smtpSettings = _configuration.GetSection("SmtpSettings");

                using (var client = new SmtpClient())
                {
                    client.Host = smtpSettings["Server"];
                    client.Port = int.Parse(smtpSettings["Port"]);
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential(smtpSettings["Username"], smtpSettings["Password"]);
                    client.EnableSsl = true;

                    using (var emailMessage = new MailMessage())
                    {
                        emailMessage.To.Add(new MailAddress(email));
                        emailMessage.Subject = assunto;
                        emailMessage.Body = messagem;
                        emailMessage.From = new MailAddress(smtpSettings["Username"]);

                        await client.SendMailAsync(emailMessage);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }

        }
    }
}

