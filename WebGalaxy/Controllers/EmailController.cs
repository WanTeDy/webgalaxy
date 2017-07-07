using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Threading.Tasks;
using WebGalaxy.Models;
using WebGalaxy.Utils.BusinessOperations.Mails;
using WebGalaxy.Utils.Objects.Requests;
using WebGalaxy.Utils.BusinessOperations.Feedbacks;
using WebGalaxy.Utils.BusinessOperations.Briefs;

namespace WebGalaxy.Controllers
{
    public class EmailController : Controller
    {
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SendMail(MailModel mail)
        {
            if (ModelState.IsValid)
            {
                var request = new RequestCreateUserMail
                {
                    Email = mail.Email,
                    Message = mail.Message,
                    Name = mail.Name,
                    Phone = mail.Phone,
                };
                var operation = new CreateMailOperation(request);
                operation.ExcecuteTransaction();
                return Json(new { Success = true });
            }
            return PartialView("Partial/_sendMailPartial", mail);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SendFeedback(FeedbackModel feedback)
        {
            if (ModelState.IsValid)
            {
                var request = new RequestCreateUserFeedback
                {
                    Company = feedback.Company,
                    Message = feedback.Message,
                    Name = feedback.Name,
                };
                var operation = new CreateFeedbackOperation(request);
                operation.ExcecuteTransaction();
                return Json(new { Success = true });
            }
            return PartialView("Partial/_sendFeedbackPartial", feedback);
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult SendBrief(BriefModel brief)
        {
            if (ModelState.IsValid)
            {
                var request = new RequestBriefMessage
                {
                    AboutCompany = brief.AboutCompany,
                    Blog = brief.Blog,
                    Corporative = brief.Corporative,
                    Cutaway = brief.Cutaway,
                    Email = brief.Email,
                    Languages = brief.Languages,
                    Message = brief.Message,
                    Name = brief.Name,
                    Promo = brief.Promo,
                    RealizationDates = brief.RealizationDates,
                    Shop = brief.Shop,
                    SiteExamples = brief.SiteExamples,
                    Phone = brief.Phone,
                };
                var operation = new CreateBriefOperation(request);
                operation.ExcecuteTransaction();
                return Json(new { Success = true });
            }
            return PartialView("Partial/_sendBriefPartial", brief);
        }
    }
}