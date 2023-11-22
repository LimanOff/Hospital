﻿using Hospital.Models.Infrastucture;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Hospital.Controllers
{
    public class HomeController : Controller
    {
        private readonly MainContext _context;
        public HomeController(MainContext context)
        {
            _context = context;
        }

        public IActionResult Index() => View();

        [HttpGet]
        public IActionResult Registration() => View();

        [HttpPost]
        public IActionResult Registration(string login, string password)
        {
            if (login != null && password != null)
            {
                User u = new() { Login = login, Password = password, RoleId = 1};
                _context.Users.Add(u);
                _context.SaveChanges();

                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Authorization() => View();

        [HttpPost]
        public IActionResult Authorization(string login, string password)
        {
            if(login != null && password != null)
            {
                User u = _context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);

                if (u != null)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();
        }

        [HttpPost]
        public IActionResult LoadAuthForm()
        {
            return RedirectToAction("Authorization");
        }

        [HttpPost]
        public IActionResult LoadRegForm()
        {
            return RedirectToAction("Registration");
        }
    }
}
