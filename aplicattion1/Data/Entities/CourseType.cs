using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class CourseType
    {
        public int Id { get; set; }


        [Display(Name = "Descripcíón")]
        [Required]

        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo {1} caracteres. ")]
        public string Description { get; set; }



    }
}
