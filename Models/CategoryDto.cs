using PPShowcase.Data.Entity;

namespace PPShowcase.Models
{
    public class CategoryDto : BaseDto
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<ProductDto> Products { get; set; }
    }
}
