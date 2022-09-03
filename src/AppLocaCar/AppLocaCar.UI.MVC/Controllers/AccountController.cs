using AppLocaCar.Application.Dto.User;
using AppLocaCar.Application.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppLocaCar.UI.MVC.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserServices _userServices;

        public AccountController(IUserServices userServices)
        {
            _userServices = userServices;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult Register(UserRegisterViewModel userRegisterViewModel)
        {

            if (ModelState.IsValid)
            {
                _userServices.RegisterUserAsync(userRegisterViewModel);
            }

            return View(userRegisterViewModel);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult LoginCustomer()
        {
            return View();
        }



        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult LoginCustomer(UserLoginViewModel userRegisterViewModel)
        {

            if (ModelState.IsValid)
            {
                _userServices.LoginCustomerAsync(userRegisterViewModel);
                return RedirectToAction("Index", "Home");
            }

            return View(userRegisterViewModel);
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult LoginEmployee()
        {
            return View();
        }
        [ValidateAntiForgeryToken]
        [HttpPost]
        public IActionResult LoginEmployee(UserEmployeeLoginViewModel userEmployeeRegisterViewModel)
        {

            if (ModelState.IsValid)
            {
                _userServices.LoginEmployeeAsync(userEmployeeRegisterViewModel);
                return RedirectToAction("Index", "Home");

            }

            return View(userEmployeeRegisterViewModel);
        }
        [HttpGet]
        public IActionResult LogOut(string redirect)
        {
            _userServices.Logout();

            return View();
        }

    }
}
