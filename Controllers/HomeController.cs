using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using login_reg.Models;

namespace login_reg.Controllers
{
    public class HomeController : Controller
    {
        [Route("")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost("create")]
        public IActionResult Create(IndexViewModel modelData)
        {
            RegUser user = modelData.NewUser;
            if(ModelState.IsValid){
                if(modelData.NewUser.Password == modelData.NewUser.PasswordConfirm)
                {
                    return RedirectToAction("show");
                } else
                {
                   return View("Index"); 
                }
            }
            return View("Index");
        }

        [HttpPost("login")]
        public IActionResult Login(IndexViewModel modelData)
        {
            LogUser user = modelData.OldUser;
            if(ModelState.IsValid)
            {
                return RedirectToAction("show");
            }
            return View("Index");
        }

        [HttpGet("show")]
        public IActionResult Show()
        {
            return View("Show");
        }
    }

}
