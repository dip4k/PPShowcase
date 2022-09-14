using PPShowcase.Data.Entity;

namespace PPShowcase.Data.Repository.impl
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(PPShowcaseContext showcaseContext) : base(showcaseContext)
        {
        }
    }
}
