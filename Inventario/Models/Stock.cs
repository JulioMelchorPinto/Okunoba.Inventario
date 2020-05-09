using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Stock : SecurityStamp
    {
        [Display(Name = "Folio de Inventario")]
        public int Id { get; set; }

        [Display(Name = "Tipo de inventario")]
        public StockType StockType { get; set; }

        //[Display(Name = "Usuario responsable")]
        //public string UserName { get; set; }
        //public virtual User User { get; set; }

        [Display(Name = "Producto")]
        public int ItemId { get; set; }
        public virtual Item Item { get; set; }

		[Display(Name = "Categoría del Producto")]
		public int ItemTypeId { get; set; }
		public virtual ItemType ItemType { get; set; }

		[Display(Name = "Empresa")]
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        [Display(Name = "Tamaño")]
        public int ItemSizeId { get; set; }
        public virtual ItemSize ItemSize { get; set; }

        [Display(Name = "Cantidad [piezas]")]
        public int Quantity { get; set; }

        [Display(Name = "Peso [kg.]")]
        public decimal Weight { get; set; }

        //public int InStockAmount { get; set; }

        //public decimal InStockWeight { get; set; }



    }
}
