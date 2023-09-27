using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PocAauth.Data
{
    public class RoleApp : IdentityRole<int>
    {
        public RoleApp()
        {
            // Default constructor is used by the framework
        }

        public RoleApp(string roleName)
            : base(roleName)
        {
        }
    }
}
