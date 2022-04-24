using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class Course
    {
        public int Id { get; set; }

        [Display(Name = "Curso")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 5 caracteres. ")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Name { get; set; }

        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public CourseType CourseType { get; set; }

    }
}
