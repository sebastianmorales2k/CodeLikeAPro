using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class Role
    {
        public int Id_Role { get; set; }
        [Display(Name = "Role")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 5 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string? Name { get; set; }
        [Display(Name = "Permisos")]
        public string? permissions { get; set; }
    }
}
