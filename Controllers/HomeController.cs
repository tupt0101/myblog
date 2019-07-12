using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProject_Blog.Models;
using System.IO;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using FinalProject_Blog.Interfaces;
using FinalProject_Blog.Database;
using FinalProject_Blog.ViewModels;

namespace FinalProject_Blog.Controllers
{
    public class HomeController : Controller
    {
        DbContext dbContext = new DbContext();
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;

        public HomeController(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }


        public IActionResult Index()
        {
            PostListViewModel vm = new PostListViewModel();
            vm.Posts = _postRepository.Posts.ToList();
            vm.CurrentCategory = "Lasted Post";
            return View(vm);
        }

        public IActionResult Menu()
        {
            return PartialView(_categoryRepository.Categories);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
