﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class Tag
    {
        public virtual int Id { get; set; }

        public virtual string Name { get; set; }

        public virtual string UrlSlug { get; set; }

        public virtual string Description { get; set; }

        public virtual List<Post> Posts { get; set; }
    }
}
