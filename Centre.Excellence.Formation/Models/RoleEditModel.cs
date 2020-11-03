using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Centre.Excellence.Formation.Models
{
    public class RoleEditModel
    {
        public IdentityRole Role { get; set; }
        public IEnumerable<ApplicationUSer> Members { get; set; }
        public IEnumerable<ApplicationUSer> NonMembers { get; set; }
    }
}
