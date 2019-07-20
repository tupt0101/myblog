using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class CommentRepository : ICommentRepository
    {
        DbContext dbContext = new DbContext();

        public int CountOfComment(int postId)
        {
            return dbContext.CountOfComment(postId);
        }

        public bool CreateComment(Comment comment)
        {
            return dbContext.CreateComment(comment);
        }

        public IEnumerable<Comment> LoadComment(int postId)
        {
            return dbContext.LoadComment(postId);
        }
    }
}
