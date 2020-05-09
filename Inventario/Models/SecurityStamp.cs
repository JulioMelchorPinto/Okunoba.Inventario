using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Inventario.Models
{
    public class SecurityStamp
    {
        [Display(Name = "Fecha de Creación")]
        [Column(TypeName = "datetime2")]
        public DateTime? CreatedDate { get; set; }

        [Display(Name = "Fecha de Modificación")]
        [Column(TypeName = "datetime2")]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Activo / Inactivo")]
        public bool IsActive { get; set; }

        [Display(Name = "Usuario identificado")]
        [DataType(DataType.Text)]
        public string Username { get; set; }
    }
}
