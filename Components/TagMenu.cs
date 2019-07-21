using FinalProject_Blog.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Components
{
    public class TagMenu : ViewComponent
    {
        private readonly ITagRepository _tagRepository;

        public TagMenu(ITagRepository tagRepository)
        {
            _tagRepository = tagRepository;
        }

        public IViewComponentResult Invoke()
        {
            var tags = _tagRepository.Tags;
            return View(tags);
        }
    }
}
