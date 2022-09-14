using System.Linq.Expressions;

using Microsoft.EntityFrameworkCore;

namespace PPShowcase.Data.Repository.impl
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected PPShowcaseContext _showcaseContext;

        public RepositoryBase(PPShowcaseContext showcaseContext)
        {
            this._showcaseContext = showcaseContext;
        }
        public void Create(T entity)
        {
            this._showcaseContext.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            this._showcaseContext.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll()
        {
            return this._showcaseContext.Set<T>().AsNoTracking();
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return _showcaseContext.Set<T>().Where(expression).AsNoTracking();
        }

        public void Update(T entity)
        {
            this._showcaseContext.Set<T>().Update(entity);
        }
    }
}
