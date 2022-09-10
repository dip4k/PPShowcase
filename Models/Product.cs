using System.ComponentModel.DataAnnotations;

namespace PPShowcase.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal UnitPrice { get; set; }
        [DataType(DataType.Date)]
        public DateTime ManufacturingDate { get; set; }
        public bool IsActive { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedDate { get; set; }
        public DateTime? LastModificationTime { get; set; }

        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
