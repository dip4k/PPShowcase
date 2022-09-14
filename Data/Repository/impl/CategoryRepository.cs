using PPShowcase.Data.Entity;

namespace PPShowcase.Data.Repository.impl
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(PPShowcaseContext showcaseContext) : base(showcaseContext)
        {
        }
    }
}
