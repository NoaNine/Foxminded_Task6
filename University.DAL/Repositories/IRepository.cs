using System.Linq.Expressions;

namespace University.DAL.Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity GetByID(TEntity entity);
        IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);
        IQueryable<TEntity> GetAllQuery();
        TEntity Insert(TEntity entity);
        TEntity Update(TEntity entity);
        void Delete(TEntity entity);
    }
}