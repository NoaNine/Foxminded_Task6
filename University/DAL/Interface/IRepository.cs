using University.Models;

namespace University.DAL.Interface
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //IQueryable<TTEntity Entities { get; }

        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAllItem();
        TEntity GetByID(TEntity entity);
        void Insert(TEntity entity);
        void Update(TEntity entity);
    }
}