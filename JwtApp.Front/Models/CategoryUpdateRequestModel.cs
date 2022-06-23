using System.ComponentModel.DataAnnotations;

namespace JwtApp.Front.Models
{
    public class CategoryUpdateRequestModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Kategori adı boş olamaz.")]
        public string? Definition { get; set; }
    }
}
