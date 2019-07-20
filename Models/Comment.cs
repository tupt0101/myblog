using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime PostedOn { get; set; }
        public string CmtContent { get; set; }
        public int PostId { get; set; }
    }
}
