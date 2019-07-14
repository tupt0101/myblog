using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using FinalProject_Blog.Models;
using FinalProject_Blog.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Controllers
{
    public class PostController : Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PostController(IPostRepository postRepository, ICategoryRepository categoryRepository)
        {
            _postRepository = postRepository;
            _categoryRepository = categoryRepository;
        }

        public ViewResult Category(string categoryId)
        {
            IEnumerable<Post> posts;
            int _categoryId = Convert.ToInt32(categoryId);
            if (_categoryId == 0)
            {
                posts = _postRepository.Posts;
            }
            else
            {
                posts = _postRepository.PostsByCategory(_categoryId);
            }
            var postListViewModel = new PostListViewModel
            {
                Posts = posts,
                CurrentCategory = _categoryRepository.CurrentCategory(_categoryId)
            };
            return View(postListViewModel);
        }

        public IActionResult Detail(string postId)
        {
            int _postId = Convert.ToInt32(postId);
            Post post = _postRepository.GetPostById(_postId);
            return View(post);
        }
    }
}
