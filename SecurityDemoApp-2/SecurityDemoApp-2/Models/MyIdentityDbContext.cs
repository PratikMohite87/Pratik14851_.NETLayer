using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityDemoApp_2.Models
{
    public class MyIdentityDbContext : IdentityDbContext<MyIdentityUser, MyIdentityRole, string>
    {
         public MyIdentityDbContext(DbContextOptions<MyIdentityDbContext> options) : base(options)
         {
            
         }
 
    }
}
