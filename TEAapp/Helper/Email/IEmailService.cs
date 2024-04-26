using Microsoft.Extensions.Configuration;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace TEAapp.Helper.Email
{
    public interface IEmailService
    {
        Task<bool> EnviarEmail(string toEmail, string subject, string message);
    }
}
