using FinalProject_Blog.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Components
{
    public class RandomPost : ViewComponent
    {
        private readonly IPostRepository _postRepository;

        public RandomPost(IPostRepository postRepository)
        {
            _postRepository = postRepository;
        }

        public IViewComponentResult Invoke()
        {
            var posts = _postRepository.RandomPosts;
            return View(posts);
        }
    }
}
