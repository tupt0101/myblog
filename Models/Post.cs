using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace FinalProject_Blog.Models
{
    public class Post
    {
        public virtual int Id { get; set; }

        public virtual string Title { get; set; }

        public virtual string ShortDescription { get; set; }

        public virtual string Description { get; set; }

        public virtual string ImgSrc { get; set; }

        public virtual string Author { get; set; }

        public virtual string UrlSlug { get; set; }

        public virtual bool Published { get; set; }

        public virtual DateTime PostedOn { get; set; }

        public virtual DateTime? Modified { get; set; }

        public virtual string Category { get; set; }

        public virtual int NumOfComment { get; set; }

        //public virtual IList<Tag> Tags { get; set; }
    }
}
