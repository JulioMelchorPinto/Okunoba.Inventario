using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.Models
{
    public enum CompanyType
    {
        [Display(Name = "Ninguno")]
        Ninguno,
        [Display(Name = "Cliente")]
        Cliente,
        [Display(Name = "Proveedor")]
        Provedor
    }
}
