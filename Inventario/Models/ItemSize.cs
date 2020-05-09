using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{ 
    public class ItemSize : SecurityStamp
    {
        public int Id { get; set; }

        [Display(Name = "Talla")]
        [Required(ErrorMessage = "Ingresa una talla.")]
        [StringLength(30)]
        public string Name { get; set; }

        [Display(Name = "Descripción")]
        [DataType(DataType.MultilineText)]
        [StringLength(500)]
        public string Description { get; set; }

       
    }
}
