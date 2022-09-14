namespace PPShowcase.Data.Repository
{
    public interface IRepositoryWrapper
    {
        ICategoryRepository Category { get; }
        IProductRepository Product { get; }
        void Save();
    }
}
