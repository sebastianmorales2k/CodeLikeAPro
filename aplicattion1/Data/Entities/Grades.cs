using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class Grades
    {
        public int id_Course { get; set; }
        [Display(Name = "Reseña")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 50")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Feedback { get; set; }
        public int id_Projects { get; set; }
        public int id_user { get; set; }
    }
}
