using AcademicApplication.Data;
using AcademicApplication.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AcademicApplication.ViewControllers
{
    [Authorize(Roles = "User")]
    public class CartController:Controller
    {
        private IEFRepository _repository;
        private UserManager<AppUser> _userManager;
        private IEmailSender _emailSender;

        public CartController(IEFRepository repository
            ,UserManager<AppUser> userManager
            , IEmailSender emailSender)
        {
            _repository = repository;
            _userManager = userManager;
            _emailSender = emailSender;
        }

        [HttpGet]
        [Authorize]
        public IActionResult AddToCart(int id)
        {
            var Course = _repository.GetCourse(id, true);
            var user = _userManager.GetUserAsync(User).Result;

            bool Status = false;
            string Message = string.Empty;

            _repository.Add(new CourseCart()
            {
                Created = DateTime.Now,
                course = Course,
                Status = CourseStatus.Active,
                Price = Course.Price,
                Appuser = user

            });

            if (_repository.SaveChange())
            {
                _emailSender.SendEmailAsync(user.Email, "One Course Is added Succesfully to Your Cart",
                      $"{Course.Title} If you want to order or buy Pl checkout    price RS: {Course.Price}");
                Status = true;
                Message = "Course Added ToCart";
                return RedirectToAction("Index", new { area = "User", controller = "CartList" });
            }
            else
            {
                Status = false;
                Message = "Error Adding Course To Cart";
            }

            return Json(new { status = Status, message = Message });
        }

        [HttpGet]
        public IActionResult GetCartData()
        {
            return ViewComponent("AcademicApplication.ViewComponents.CartList");
        }

        [HttpGet]
        public IActionResult DeleteCart(int id)
        {
            bool Status = false;
            string Message = string.Empty;
            var result = _repository.GetCartById(id);
            if (result == null)
            {

            }
            _repository.Delete(result);

            if (_repository.SaveChange())
            {
                Status = true;
                Message = "Course Deleted sucessfulllllllly";
                return RedirectToAction("Index", new { area = "", controller = "CartList" });
            }
            else
            {
                Status = false;
                Message = "error deleting course";
            }
            return Json(new { status = Status, message = Message });
        }

        [HttpGet]
        public IActionResult PaidCourse(int id)
        {

            bool Status = false;
            string Message = string.Empty;
            var result = _repository.GetCartById(id);

            if(result == null)
            {
                return NotFound("course Not found in cart");
            }

            var paid = new PaidCourses()
            {
                course=result.course,
                Price=result.Price,
                Appuser=result.Appuser
            };

            _repository.Add(paid);

            if (_repository.SaveChange())
            {
                Status = true;
                Message = "Course Deleted sucessfulllllllly";
            }
            else
            {
                Status = false;
                Message = "error deleting course";
            }
            return View();

           
        }
    }
    
}   
