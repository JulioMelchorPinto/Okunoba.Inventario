using Inventario.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Inventario.ViewModels
{
    public class UserViewModel
    {
        [Display(Name = "Usuario")]

        public AppUser User { get; set; }
        [Display(Name = "Roles")]

        public ICollection<string> RolesNames { get; set; }
    }
}