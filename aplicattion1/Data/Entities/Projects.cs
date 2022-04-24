using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class Projects
    {
        public int Id_Projects { get; set; }
        [Display(Name = "Nombre")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 5 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Name { get; set; }
        [Display(Name = "Descripcion")]
        public string description { get; set; }
        [Display(Name = "ID notas del curso")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public int Id_grades { get; set; }
        [Display(Name = "Modalidad")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public Modality Modality { get; set; }

    }
}
