namespace PPShowcase.Data.Repository.impl
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private readonly PPShowcaseContext _showcaseContext;
        private ICategoryRepository _category;
        private IProductRepository _product;
        public ICategoryRepository Category
        {
            get
            {
                if (_category == null)
                {
                    _category = new CategoryRepository(_showcaseContext);
                }
                return _category;
            }
        }
        public IProductRepository Product
        {
            get
            {
                if (_product == null)
                {
                    _product = new ProductRepository(_showcaseContext);
                }
                return _product;
            }
        }
        public RepositoryWrapper(PPShowcaseContext repositoryContext)
        {
            _showcaseContext = repositoryContext;
        }
        public void Save()
        {
            _showcaseContext.SaveChanges();
        }
    }
}
