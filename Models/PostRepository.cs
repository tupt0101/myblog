using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class PostRepository : IPostRepository
    {
        DbContext dbContext = new DbContext();

        public IEnumerable<Post> Posts
        {
            get
            {
                return dbContext.GetAllPosts();
            }
        }

        public IEnumerable<Post> RandomPosts
        {
            get
            {
                return dbContext.GetRandomPost();
            }
        }

        public Post GetPostById(int Id)
        {
            return dbContext.GetPostById(Id);
        }

        public IEnumerable<Post> PostsByCategory(int categoryId)
        {
            return dbContext.GetPostByCategoryId(categoryId);
        }

        public IEnumerable<Post> PostsBySearchKey(string searchKey)
        {
            return dbContext.SearchByKey(searchKey);
        }

        public bool SaveSubscribeEmail(string email)
        {
            return dbContext.SaveSubscribeEmail(email);
        }
    }
}
