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
    }
}
