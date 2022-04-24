using System.ComponentModel.DataAnnotations;

namespace aplicattion1.Data.Entities
{
    public class DocumentType
    {
        [Key]
        public int Id_DocumentType { get; set; }
        [MaxLength(200)]
        [Display(Name = "Descripcion")]
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Description { get; set; }
    }
}
