using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.ViewModels
{
    public class ItemInStock
    {
        [Display(Name = "Producto")]
        public string ItemName { get; set; }
        [Display(Name = "Talla")]
        public string ItemSizeName { get; set; }
        [Display(Name = "Categoría")]
        public string ItemTypeName { get; set; }
        [Display(Name = "Cantidad Total [piezas]")]
        public int Quantity { get; set; }
        [Display(Name = "Peso Total [kg]")]
        public decimal Weight { get; set; }
    }
}
