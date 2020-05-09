using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Role : SecurityStamp
    {
        public Role() { }
        public Role(IdentityRole role)
        {
            Id = role.Id;
            Name = role.Name;
            CreatedDate = DateTime.Now;
            IsActive = true;
           
            ModifiedDate = null;

        }
        public string Id { get; set; }
        [Required(ErrorMessage = "Ingresa un nombre para el rol.")]
        [Display(Name="Rol de usuario")]
        public string Name { get; set; }
    }
}