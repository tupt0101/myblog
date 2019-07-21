using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Username { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        public DateTime PostedOn { get; set; }
        public string CmtContent { get; set; }
        public int PostId { get; set; }
    }
}
