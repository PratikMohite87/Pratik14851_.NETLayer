using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SecurityDemoApp_2.Models
{
    public class MyIdentityUser : IdentityUser
    {
        public string FullName { set; get; }
        public DateTime BirthDate { set; get; }
    }
}
