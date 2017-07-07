using System;
using System.Collections.Generic;
using System.Linq;
using WebGalaxy.Utils.Entities;
using WebGalaxy.Utils.Helpers;
using WebGalaxy.Utils.Objects.Requests;

namespace WebGalaxy.Utils.BusinessOperations.Mails
{
    public class CreateMailOperation : BaseOperation
    {
        private RequestCreateUserMail Request { get; set; }

        public CreateMailOperation(RequestCreateUserMail request)
        {
            Request = request;
            RussianName = "Сообщение администрации";
        }

        protected override void PrepareAndCheck()
        {
            base.PrepareAndCheck();
        }

        protected override void PerformOperation()
        {
            base.PerformOperation();
            Context.UserMails.Add(new UserMail
            {
                Date = DateTime.Now,
                Email = Request.Email,
                Message = Request.Message,
                Name = Request.Name,
                Phone = Request.Phone
            });
            Context.SaveChanges();
            Send();
        }

        private void Send()
        {
            SmtpEmailSender mailSender = new SmtpEmailSender("mail.web-galaxy.com.ua", "postmaster@web-galaxy.com.ua", "WebGalaxyAdmin!");
            var body = SmtpEmailSender.GetHtmlRazor(Request, SmtpEmailSender.FormatUrl("UserMailView"));

            mailSender.Send("info@web-galaxy.com.ua", "Новое сообщение", body);
        }
    }
}