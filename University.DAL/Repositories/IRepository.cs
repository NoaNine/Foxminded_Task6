using System.Linq.Expressions;

namespace University.DAL.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter);
        IQueryable<TEntity> GetAllQuery();
        TEntity GetByID(TEntity entity);
        IEnumerable<TEntity> GettAll();
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
    }
}