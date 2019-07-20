using FinalProject_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Interfaces
{
    public interface IPostRepository
    {
        IEnumerable<Post> Posts { get; }

        Post GetPostById(int Id);

        IEnumerable<Post> PostsByCategory(int categoryId);

        IEnumerable<Post> RandomPosts { get; }

        IEnumerable<Post> PostsBySearchKey(string searchKey);

        bool SaveSubscribeEmail(string email);

        bool CreatePost(Post post);

        bool UpdatePost(Post post);

        bool DeletePost(int Id);
    }
}
