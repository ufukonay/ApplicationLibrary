using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using Database.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication26.Controllers
{
    public class Category : Controller
    {
        CategoryMenager cm = new CategoryMenager(new EfCategoryRepository());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);

        }
    }
}
