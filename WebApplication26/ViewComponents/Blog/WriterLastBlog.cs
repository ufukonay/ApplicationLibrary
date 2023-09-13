using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using Database.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication26.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {
            var values = bm.GetBlogListByWriter(5);
            return View(values);
        }
    }
}
