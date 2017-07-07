using System;
using System.Collections.Generic;
using System.Linq;
using WebGalaxy.Utils.Entities;
using WebGalaxy.Utils.Helpers;
using WebGalaxy.Utils.Objects.Requests;

namespace WebGalaxy.Utils.BusinessOperations.Feedbacks
{
    public class CreateFeedbackOperation : BaseOperation
    {
        private RequestCreateUserFeedback Request { get; set; }

        public CreateFeedbackOperation(RequestCreateUserFeedback request)
        {
            Request = request;
            RussianName = "Отзыв пользователя";
        }

        protected override void PrepareAndCheck()
        {
            base.PrepareAndCheck();
        }

        protected override void PerformOperation()
        {
            base.PerformOperation();
            Context.UserFeedbacks.Add(new UserFeedback
            {
                Date = DateTime.Now,
                Company = Request.Company,
                Message = Request.Message,
                Name = Request.Name,
            });
            Context.SaveChanges();
            Send();
        }

        private void Send()
        {
            SmtpEmailSender mailSender = new SmtpEmailSender("mail.web-galaxy.com.ua", "postmaster@web-galaxy.com.ua", "WebGalaxyAdmin!");
            var body = SmtpEmailSender.GetHtmlRazor(Request, SmtpEmailSender.FormatUrl("UserFeedbackView"));

            mailSender.Send("info@web-galaxy.com.ua", "Новый отзыв", body);
        }
    }
}