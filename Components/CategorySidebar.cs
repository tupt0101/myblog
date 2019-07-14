using FinalProject_Blog.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Components
{
    public class CategorySidebar : ViewComponent
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategorySidebar(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.Categories;
            return View(categories);
        }
    }
}
