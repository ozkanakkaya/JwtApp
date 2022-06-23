using System.ComponentModel.DataAnnotations;

namespace JwtApp.Front.Models
{
    public class CategoryCreateRequestModel
    {
        [Required(ErrorMessage ="Kategori adı boş olamaz.")]
        public string? Definition { get; set; }
    }
}
