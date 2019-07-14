using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        DbContext dbContext = new DbContext();

        public IEnumerable<Category> Categories
        {
            get
            {
                return dbContext.GetAllCategories();
            }
        }

        public string CurrentCategory(int categoryId)
        {
            List<Category> categories = dbContext.GetAllCategories().ToList();
            foreach (Category item in categories)
            {
                if (item.Id == categoryId)
                    return item.Name;
            }
            return string.Empty;
        }
    }
}
