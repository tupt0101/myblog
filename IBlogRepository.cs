using Personal_Blog.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Blog
{
    public interface IBlogRepository
    {
        IList<Post> Posts(int pageNum, int pageSize);

        int TotalPosts();
    }
}
