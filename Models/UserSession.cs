using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Models
{
    [Serializable]
    public class UserSession
    {        
        public string Email { get; set; }

        public string Role { get; set; }
    }
}
