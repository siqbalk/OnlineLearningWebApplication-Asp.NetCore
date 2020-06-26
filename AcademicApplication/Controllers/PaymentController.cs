
using AcademicApplication.Data;
using AcademicApplication.Models;
using AcademicApplication.Services;
using AcademicApplication.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcademicApplication.ViewControllers
{
    public class PaymentController : Controller
    {

        public PaymentController(IEFRepository repository,
            UserManager<AppUser>  userManager,
              IEmailSender emailSender ,
              ISmsSender smsSender)
        {
            _repository = repository;
            _userManager = userManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
        }

        private int amount = 100;
        private IEFRepository _repository;
        private UserManager<AppUser> _userManager;
        private IEmailSender _emailSender;
        private ISmsSender _smsSender;

        public IActionResult Index(int id)
        {
            bool Status = false;
            string Message = string.Empty;
            var result = _repository.GetCartById(id,true);
            var updatecours = _repository.GetCourse(result.course.CourseId, true);
            //var user = _userManager.GetUserAsync(User).Result;
            var subscribecourses = _repository.GetSubscribeByCourseId(result.course.CourseId, true);

            if (subscribecourses != null){
                foreach(var sub in subscribecourses)
                {
                     _emailSender.SendEmailAsync(sub.Appuser.Email, "Your Subscribe Course",
                       $"{sub.course.Title} Has been Sold out ....Plz Unsubscribe this course....it  is no more available");
                }
            }

            if (result == null)
            {
                return NotFound("course Not found in cart");
            }

            if(updatecours !=null)
            {
                updatecours.IsPaid = true;
                updatecours.courseStatus = CourseStatus.Passive;
                _repository.Update(updatecours);

                if (_repository.SaveChange())
                {
                   
                }
            }


            var paid = new PaidCourses()
            {
                course = result.course,
                Price = result.Price,
                Appuser = result.Appuser
            };

            var model = new CourseListViewModel()
            {
                Title=result.course.Title,
                Description=result.course.ShortDescription,
                Price=result.Price

            };

            _repository.Add(paid);
            //_repository.Delete(result);

            if (_repository.SaveChange())
            {

                //message and subject
                string message = $"In case you need some other courses we will be always welcome you..." +
                       $"\n FOLLOWING INFORMATION ABOUT COURSE" +
                       $"\n PRICE RS:{result.course.Price}" +
                       $"\n DURATION:{result.course.Duration} DAYS";

                string subject = $"Thanks For Buying  {result.course.Title}";

                string mobilemsg = subject + message;
                //sending email after bying course..
                _emailSender.SendEmailAsync(result.Appuser.Email, subject,message);

                //sending sms after bying course
                _smsSender.SendSmsAsync(result.Appuser.PhoneNumber, mobilemsg);

                Status = true;
                Message = "Course Deleted sucessfulllllllly";
            }
            else
            {
                Status = false;
                Message = "error deleting course";
            }
            ViewBag.PaymentAmount = amount;
            return View(model);
        }

        [HttpPost]
        public IActionResult Processing(string stripeToken, string stripeEmail)
        {
            Dictionary<string, string> Metadata = new Dictionary<string, string>();
            Metadata.Add("Product", "RubberDuck");
            Metadata.Add("Quantity", "10");
            var options = new ChargeCreateOptions
            {
                Amount = amount,
                Currency = "USD",
                Description = "Buying 10 rubber ducks",
                Source = stripeToken,
                ReceiptEmail = stripeEmail,
                Metadata = Metadata
            };
            var service = new ChargeService();
            Charge charge = service.Create(options);
            return View();
        }
    }
}
