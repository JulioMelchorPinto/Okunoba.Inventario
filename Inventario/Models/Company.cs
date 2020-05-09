using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Inventario.Models
{
    public class Company : SecurityStamp
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Escribe un nombre")]
        [Display(Name = "Empresa"), StringLength(100)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Selecciona la contribución de la empresa")]
        [Display(Name = "Tipo de Compañía")]
        public CompanyType CType { get; set; }

        [Display(Name = "Teléfono"), DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }

        [Display(Name = "Teléfono Móbil"), DataType(DataType.PhoneNumber)]
        public string Mobile { get; set; }

        [Display(Name = "Correo electrónico"), DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Display(Name = "Sitio Web"), DataType(DataType.Url)]
        public string WebSite { get; set; }

        //[Required]
        //[DisplayName("Contact Person: ")]
        //public string ContactPerson { get; set; }
    }
}
