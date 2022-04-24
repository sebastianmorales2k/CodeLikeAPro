using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class UserRole
    {
        [Display(Name = "Id de usuario")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public int Id_User { get; set; }

        [Display(Name = "[Id de role")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Id_Role { get; set; }

    }
}
