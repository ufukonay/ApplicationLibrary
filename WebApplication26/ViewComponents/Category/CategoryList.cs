using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using Database.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication26.ViewComponents.Category
{

    public class CategoryList:ViewComponent
    {
        CategoryMenager cm = new CategoryMenager( new EfCategoryRepository());
       public IViewComponentResult Invoke()
        {
            var values = cm.GetList();
            return View(values);
        }


    }
}
