using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProject_Blog.Database
{
    public class UserDBContext : IdentityDbContext<IdentityUser>
    {

    }
}
