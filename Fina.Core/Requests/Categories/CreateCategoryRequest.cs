using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories
{
    public class CreateCategoryRequest : Request
    {
        [Required(ErrorMessage = "Título é obrigatório.")]
        [MaxLength(80, ErrorMessage = "Título deve conter até 80 dígitos.")]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Descrição é obrigatória.")]
        public string Description { get; set; } = string.Empty;
    }
}
