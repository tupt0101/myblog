using FinalProject_Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.ViewModels
{
    public class PostListViewModel
    {
        public IEnumerable<Post> Posts { get; set; }

        
        public string CurrentCategory { get; set; }
    }
}
