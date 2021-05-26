using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecurityDemoApp_2.Models
{
    public class MyIdentityRole : IdentityRole
    {
        public string Description { set; get; }

        public MyIdentityRole() { }

        public MyIdentityRole(string role) : base(role)
        { }
    }
}
