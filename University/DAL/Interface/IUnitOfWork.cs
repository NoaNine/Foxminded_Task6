namespace University.DAL.Interface
{
    public interface IUnitOfWork
    {
        void Dispose();
        IRepository<TEntity> GetRepository<TEntity>() where TEntity : class;
        void Save();
    }
}