using System.ComponentModel.DataAnnotations;

using PPShowcase.Data.Entity;

namespace PPShowcase.Models
{
    public class CategoryDto : BaseDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}
