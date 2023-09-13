﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using Database.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication26.ViewComponents.Comment
{
    public class CommentListByBlog : ViewComponent
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IViewComponentResult Invoke(int id  )
        {
            var values = cm.GetList(id);
            return View(values);
        }
    }
}