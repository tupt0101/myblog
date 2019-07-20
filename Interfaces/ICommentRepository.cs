using FinalProject_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Interfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> LoadComment(int postId);

        int CountOfComment(int postId);

        bool CreateComment(Comment comment);
    }
}
