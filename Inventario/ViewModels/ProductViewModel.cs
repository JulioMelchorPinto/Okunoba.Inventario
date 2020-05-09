using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Inventario.ViewModels
{
    public class ProductViewModel
    {
        [Display(Name = "Producto")]
        public string ProductName { get; set; }
        [Display(Name = "Categorías")]
        public ICollection<string> ProductTypes { get; set; }
        [Display(Name = "Tallas")]
        public ICollection<string> ProductSizes { get; set; }
        [Display(Name = "Cantidad Total [piezas]")]
        public int SumAmount { get; set; }
        [Display(Name = "Peso Total [kg]")]
        public decimal SumWeight { get; set; }
        public int SumAmountByTypes { get; set; }
        public decimal SumWeightByTypes { get; set; }
        public int SumAmountBySizes { get; set; }
        public decimal SumWeightBySizes { get; set; }
    }
}
