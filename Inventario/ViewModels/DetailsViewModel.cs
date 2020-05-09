using Inventario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.ViewModels
{
    public class DetailsViewModel
    {
        [Display(Name = "Producto")]
        public string ItemName { get; set; }
        [Display(Name = "Talla")]
        public string ItemSizeName { get; set; }
        [Display(Name = "Categoría")]
        public string ItemTypeName { get; set; }
        [Display(Name = "Cantidad Total [piezas]")]
        public int TotalQuantity { get; set; }
        [Display(Name = "Peso Total [kg]")]
        public decimal TotalWeight { get; set; }
        [Display(Name = "Cantidad Débil [piezas]")]
        public int DebilQuantity { get; set; }
        [Display(Name = "Peso Débil [piezas]")]
        public decimal DebilWeight { get; set; }

        //public IEnumerable<string> ItemSizeNames { get; set; }
        //public IEnumerable<string> ItemTypeNames { get; set; }
        public ICollection<Stock> ItemTypes { get; set; }
        public ICollection<int> Quantities { get; set; }
        public ICollection<decimal> Weights { get; set; }

        public DetailsViewModel()
        {
            Quantities = new List<int>();
            Weights = new List<decimal>();
        }
    }
}

