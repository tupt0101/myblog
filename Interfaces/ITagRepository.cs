using FinalProject_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Interfaces
{
    public interface ITagRepository
    {
        IEnumerable<Tag> Tags { get; }

        Tag GetTagById(int Id);

        bool CreateTag(Tag tag);

        bool UpdateTag(Tag tag);

        bool DeleteTag(int Id);
    }
}
