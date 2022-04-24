using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class FamousProjects
    {
        [Key]
        public int Id_FamousProjects { get; set; }
        [Display(Name = "Nombre del Proyecto")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 50 caracteres. ")]
        public string Name { get; set; }
        [Display(Name = "Id del Curso")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public int Id_Course { get; set; }
        [Display(Name = "Id del instituto")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public int Id_Institute { get; set; }
        [Display(Name = "Archivos del desarrollo")]
        public string path { get; set; }

    }
}
