using FinalProject_Blog.Database;
using FinalProject_Blog.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class TagRepository : ITagRepository
    {
        DbContext dbContext = new DbContext();

        public IEnumerable<Tag> Tags
        {
            get
            {
                return dbContext.GetAllTags();
            }
        }

        public bool CreateTag(Tag tag)
        {
            return dbContext.CreateTag(tag);
        }

        public bool DeleteTag(int Id)
        {
            return dbContext.DeleteTag(Id);
        }

        public Tag GetTagById(int Id)
        {
            return dbContext.GetTagById(Id);
        }

        public bool UpdateTag(Tag tag)
        {
            return dbContext.UpdateTag(tag);
        }
    }
}
