using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using FinalProject_Blog.Interfaces;
using FinalProject_Blog.Models;
using FinalProject_Blog.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProject_Blog.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly ITagRepository _tagRepository;
        private readonly IHostingEnvironment he;

        public AdminController(IPostRepository postRepository, ICategoryRepository categoryRepository, ITagRepository tagRepository, IHostingEnvironment environment)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
            _tagRepository = tagRepository;
            he = environment;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// All actions with Post
        /// </summary>
        /// <returns></returns>
        public IActionResult Post()
        {
            IEnumerable<Post> posts = _postRepository.Posts;
            var model = new PostListViewModel
            {
                Posts = posts
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult CreatePost()
        {
            IEnumerable<Category> categories = _categoryRepository.Categories;
            ViewBag.listCat = categories;
            return View();
        }
        [HttpPost]
        public IActionResult CreatePost([Bind] Post post, IFormFile Image)
        {
            if (Image != null)
            {
                var fileName = Path.Combine(he.WebRootPath + "\\images\\", Path.GetFileName(Image.FileName));
                Image.CopyTo(new FileStream(fileName, FileMode.Create));
                post.ImgSrc = "../images/" + Image.FileName;
            }
            post.PostedOn = DateTime.Now;
            _postRepository.CreatePost(post);
            return RedirectToAction("Post");
        }

        [HttpGet]
        public IActionResult EditPost(int Id)
        {
            Post post = _postRepository.GetPostById(Id);
            IEnumerable<Category> categories = _categoryRepository.Categories;
            ViewBag.listCat = categories;
            return View(post);
        }
        [HttpPost]
        public IActionResult EditPost([Bind] Post post, IFormFile Image)
        {
            if (Image != null)
            {
                var fileName = Path.Combine(he.WebRootPath + "\\images\\", Path.GetFileName(Image.FileName));
                Image.CopyTo(new FileStream(fileName, FileMode.Create));
                post.ImgSrc = "../images/" + Image.FileName;
            }
            int id = post.Id;
            post.Modified = DateTime.Now;
            _postRepository.UpdatePost(post);
            return RedirectToAction("Post");
        }

        public IActionResult DeletePost(int Id)
        {
            _postRepository.DeletePost(Id);
            return RedirectToAction("Post");
        }

        /// <summary>
        /// All actions with Category
        /// </summary>
        /// <returns></returns>
        public IActionResult Category()
        {
            IEnumerable<Category> categories = _categoryRepository.Categories;
            return View(categories);
        }

        [HttpGet]
        public IActionResult CreateCategory()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult CreateCategory([Bind] Category category)
        {
            _categoryRepository.CreateCategory(category);
            return RedirectToAction("Category");
        }

        [HttpGet]
        public IActionResult EditCategory(int id)
        {
            Category category = _categoryRepository.GetCategoryById(id);
            return View(category);
        }
        [HttpPost]
        public IActionResult EditCategory([Bind] Category category)
        {
            _categoryRepository.UpdateCategory(category);
            return RedirectToAction("Category");
        }

        public IActionResult DeleteCategory(int id)
        {
            _categoryRepository.DeleteCategory(id);
            return RedirectToAction("Category");
        }

        /// <summary>
        /// All actions with Tags
        /// </summary>
        /// <returns></returns>
        public IActionResult Tag()
        {
            IEnumerable<Tag> tags = _tagRepository.Tags;
            return View(tags);
        }

        [HttpGet]
        public IActionResult CreateTag()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateTag([Bind] Tag tag)
        {
            _tagRepository.CreateTag(tag);
            return RedirectToAction("Tag");
        }

        [HttpGet]
        public IActionResult EditTag(int id)
        {
            Tag tag = _tagRepository.GetTagById(id);
            return View(tag);
        }
        [HttpPost]
        public IActionResult EditTag(int id, [Bind] Tag tag)
        {
            _tagRepository.UpdateTag(tag);
            return RedirectToAction("Tag");
        }

        public IActionResult DeleteTag(int id)
        {
            _tagRepository.DeleteTag(id);
            return RedirectToAction("Tag");
        }
    }
}