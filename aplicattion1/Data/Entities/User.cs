using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class User
    {
        [Display(Name = "Primer nombre")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 50 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string First_name { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 50 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Last_name { get; set; }

        [Display(Name = "Tipo de documento")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public DocumentType DocumentType { get; set; }

        [Display(Name = "Documento")]
        [MaxLength(20, ErrorMessage = "el campo {0} debe tener maximo 50 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Document { get; set; }

        [Display(Name = "Direccion")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 50 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Address { get; set; }
        public Guid ImageId { get; set; }
        public UserRole UserRole { get; set; }
    }
}
