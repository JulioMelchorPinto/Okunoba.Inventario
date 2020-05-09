using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public class Item : SecurityStamp
    {
        public int Id { get; set; }
        [Display(Name = "Producto")]
        public string Name { get; set; }       
    }
}
