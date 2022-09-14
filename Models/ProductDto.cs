using PPShowcase.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace PPShowcase.Models
{
    public class ProductDto : BaseDto
    {
        public string Code { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public bool IsActive { get; set; }
        public virtual CategoryDto Category { get; set; }
    }
}
