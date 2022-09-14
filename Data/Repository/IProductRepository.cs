using System.Linq.Expressions;

using PPShowcase.Data.Entity;

namespace PPShowcase.Data.Repository
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllWithCategory(Expression<Func<Product, Category>> expression);
    }
}
