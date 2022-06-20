using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using MimeKit.Text;
using MailKit.Security;

namespace SimpleEmailApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailController : ControllerBase
    {
        private readonly IEmailService _emailService;
        public EmailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpPost]
        public IActionResult SendEmail(EmailDTO request)
        {
            //var email = new MimeMessage();
            //email.From.Add(MailboxAddress.Parse("ibdxxmmqpl2o7fp6@ethereal.email"));
            //email.To.Add(MailboxAddress.Parse("ibdxxmmqpl2o7fp6@ethereal.email"));
            //email.Subject = "Test Email Subject";
            //email.Body = new TextPart(TextFormat.Html) { Text = body };

            //using var smtp = new SmtpClient();
            //smtp.Connect("smtp.ethereal.email", 587, SecureSocketOptions.StartTls);
            //smtp.Authenticate("ibdxxmmqpl2o7fp6@ethereal.email", "qC8gBfXDtcuBAsKQTB");
            //smtp.Send(email);
            //smtp.Disconnect(true);

            _emailService.SendEmail(request);

            return Ok();
        }
    }
}
