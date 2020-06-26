using AcademicApplication.Data;
using AcademicApplication.Models;
using AcademicApplication.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AcademicApplication.Controllers
{
    [Authorize(Roles = "User")]
    public class SubscribeController : Controller
    {
        private IEFRepository _repository;
        private UserManager<AppUser> _userManager;
        private IEmailSender _emailSender;
        private ISmsSender _smsSender;

        public SubscribeController(IEFRepository repository,
            UserManager<AppUser> userManager,
            IEmailSender emailSender,
            ISmsSender smsSender)
        {
            _repository = repository;
            _userManager = userManager;
            _emailSender = emailSender;
            _smsSender = smsSender;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        string messages = null;
        public SMSoptions Options { get; }
        [HttpGet]
        public IActionResult Subscribe(int id)
        {
            var Course = _repository.GetCourse(id, true);
            var user = _userManager.GetUserAsync(User).Result;

            bool Status = false;
            string Message = string.Empty;

            if (Course == null)
            {
                NotFound("Course Not Found");
            }


            _repository.Add(new CourseSubscribe()
            {
                Created = DateTime.Now,
                course = Course,
                Status = CourseStatus.Active,
                Appuser = user,
                //IssSubscribe=true

            });

            if (_repository.SaveChange())
            {

              //Message and subject 
                string messages = $"{Course.Title} .... Is Added to Your Subscribed  Price RS:{Course.Price} ....Duration {Course.Duration} Days...If you like it plz  checkout .....Thanks";
                string Subject = $"{Course.Title} .... Is Added to Your Subscribed List";

                //Sending sms while subscribing subjsct
                _smsSender.SendSmsAsync(user.PhoneNumber, messages);


                //Sending Email while subscribing subjsct
                _emailSender.SendEmailAsync(user.Email,Subject,messages);

                Status = true;
                Message = "Course Subscribed successfully";
                //return RedirectToAction("Index", new { area = "User", controller = "SubsribeCourses" });
            }
            else
            {
                Status = false;
                Message = "Error Adding Course To Cart";
            }

            return Json(new { status = Status, message = Message });
        }
    }
}
