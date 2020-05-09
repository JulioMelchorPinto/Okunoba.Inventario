using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.ViewModels
{
    public class StockViewModel
    {
        [Display(Name = "Producto")]
        public string ItemName { get; set; }

        [Display(Name = "Cantidad Total [piezas]")]
        public int TotalQuantity { get; set; }
        [Display(Name = "Peso Total [kg]")]
        public decimal TotalWeight { get; set; }
        [Display(Name = "Cantidad Débil [piezas]")]
        public int DebilQuantity { get; set; }
        [Display(Name = "Peso Débil [kg]")]
        public decimal DebilWeight { get; set; }
        public ICollection<DetailsViewModel> DetailsList { get; set; }


    }
}
