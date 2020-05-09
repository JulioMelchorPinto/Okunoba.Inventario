using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace Inventario.Models
{
    public class RoleEdit
    {
        public AppRole Role { get; set; }
        public IEnumerable<AppUser> Members { get; set; }
        public IEnumerable<AppUser> NonMembers { get; set; }
    }
}

