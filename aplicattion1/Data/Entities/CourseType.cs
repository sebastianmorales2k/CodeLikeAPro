using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class CourseType
    {
        public int Id { get; set; }


        [Display(Name ="Descripción")]    
        [Required(ErrorMessage = "El campo {0} es obligatorio ")]  

        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo {1} caracteres. ")]
        public string Description { get; set; }


        public ICollection<Course> Courses { get; set; }



    }
}
