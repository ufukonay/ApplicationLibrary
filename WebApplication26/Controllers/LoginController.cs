using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Database.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication26.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
       
        [HttpPost]
        [AllowAnonymous]
        public IActionResult Index(Writer p)
        {
            Context c = new Context();
            var datavalue = c.Writers.FirstOrDefault(x => x.WriterMail == p.WriterMail && x.WriterPassword == p.WriterPassword);
            if (datavalue != null)
            {
                HttpContext.Session.SetString("username", p.WriterMail);
                return RedirectToAction("Index", "Writer");
            }
            else
            {
                ViewBag.Message = "Invalid user details!";
                return View();
            }
        }
    }
    }

