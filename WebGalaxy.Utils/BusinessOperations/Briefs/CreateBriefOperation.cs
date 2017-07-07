using System;
using System.Collections.Generic;
using System.Linq;
using WebGalaxy.Utils.Entities;
using WebGalaxy.Utils.Helpers;
using WebGalaxy.Utils.Objects.Requests;

namespace WebGalaxy.Utils.BusinessOperations.Briefs
{
    public class CreateBriefOperation : BaseOperation
    {
        private RequestBriefMessage Request { get; set; }

        public CreateBriefOperation(RequestBriefMessage request)
        {
            Request = request;
            RussianName = "Сообщение бриф";
        }

        protected override void PrepareAndCheck()
        {
            base.PrepareAndCheck();
        }

        protected override void PerformOperation()
        {
            base.PerformOperation();
            Context.UserBriefs.Add(new UserBrief
            {
                Date = DateTime.Now,
                AboutCompany = Request.AboutCompany,
                Blog = Request.Blog,
                Corporative = Request.Corporative,
                Cutaway = Request.Cutaway,
                Email = Request.Email,
                Languages = Request.Languages,
                Message = Request.Message,
                Name = Request.Name,
                Promo = Request.Promo,
                RealizationDates = Request.RealizationDates,
                Shop = Request.Shop,
                SiteExamples = Request.SiteExamples,
                Phone = Request.Phone,

            });
            Context.SaveChanges();
            Send();
        }

        private void Send()
        {
            SmtpEmailSender mailSender = new SmtpEmailSender("mail.web-galaxy.com.ua", "postmaster@web-galaxy.com.ua", "WebGalaxyAdmin!");
            var body = SmtpEmailSender.GetHtmlRazor(Request, SmtpEmailSender.FormatUrl("UserBriefView"));

            mailSender.Send("info@web-galaxy.com.ua", "Новый бриф", body);
        }
    }
}