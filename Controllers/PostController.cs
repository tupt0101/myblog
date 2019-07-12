using FinalProject_Blog.Database;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Controllers
{
    public class PostController : Controller
    {
        DbContext dbContext = new DbContext();

        public PostController()
        {

        }

        public IActionResult DisplayByCategory()
        {
            return View();
        }
    }
}
