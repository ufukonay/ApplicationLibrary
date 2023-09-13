using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication26.Controllers
{
    public class WriterController : Controller
    {
     [AllowAnonymous]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriteProfile()
        {
            return View();
       }
        public IActionResult WriterMail()
        {
            return View();
        }
    }
}
