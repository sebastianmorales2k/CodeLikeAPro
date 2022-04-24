using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class Institute
    {
        public int Id_Institte { get; set; }
        [Display(Name = "Nombre del instituto")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        [MaxLength(50, ErrorMessage = "el campo {0} debe tener maximo 50 caracteres. ")]
        public string Name_Institute { get; set; }
        [Display(Name = "Tipo de instituto")]
        public string InstitutionType { get; set; }
        [Display(Name = "Ranking")]
        public int Ranking { get; set; }
        [Display(Name = "Sector")]
        public string Sector { get; set; }
        [Display(Name = "Lenguajes de programacion")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public string Languages { get; set; }
        [Display(Name = "Id del Curso")]
        [Required(ErrorMessage = "el campo {0} es obligatorio. ")]
        public int id_Course { get; set; }

    }
}
