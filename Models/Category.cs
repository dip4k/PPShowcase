namespace PPShowcase.Models
{
    public class Category
    {

        public int CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime AddedDate { get; set; }
        public DateTime? LastModificationTime { get; set; }
    }
}
