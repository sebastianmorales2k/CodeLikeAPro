using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class Modality
    {
        public int Id_Modality { get; set; }
        [Display(Name = "Nombre de la modalidad")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 5 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Name { get; set; }
        [Display(Name = "Lenguajes")]
        public string languages { get; set; }

    }
}
