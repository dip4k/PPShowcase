using System.ComponentModel.DataAnnotations;

namespace PPShowcase.Data.Entity
{
    public class Product : BaseEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }

        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
