using System.ComponentModel.DataAnnotations;

namespace PPShowcase.Data.Entity
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime? LastModificationTime { get; set; }
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}
