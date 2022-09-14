using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

using PPShowcase.Data.Entity;

namespace PPShowcase.Data.Repository.impl
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(PPShowcaseContext showcaseContext) : base(showcaseContext)
        {
        }

        public IQueryable<Product> GetAllWithCategory(Expression<Func<Product, Category>> expression)
        {
            return _showcaseContext.Product.Include(expression).AsNoTracking();
        }
    }
}
