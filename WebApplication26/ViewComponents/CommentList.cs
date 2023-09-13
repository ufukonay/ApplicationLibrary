using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication26.Models;

namespace WebApplication26.ViewComponents
{
    public class CommentList: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentvalues = new List<UserComment>
            {
                new UserComment
                {
                    ID=1,
                    Username="Ufuk"
                },
                new UserComment
                {
                    ID=2,
                    Username="Cenk"
                }
            };

            return View(commentvalues);
        }
    }
}
