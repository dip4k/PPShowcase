using PPShowcase.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PPShowcase.Models
{
    public class ProductDto : BaseDto
    {
        [Required]
        public string Code { get; set; }
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        [DataType(DataType.Currency)]
        [Range(1,int.MaxValue,ErrorMessage ="Enter valid price.")]
        public decimal UnitPrice { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        
        public bool IsActive { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Please select valid category")]
        public int CategoryId { get; set; }
        public CategoryDto Category { get; set; }
    }
}
