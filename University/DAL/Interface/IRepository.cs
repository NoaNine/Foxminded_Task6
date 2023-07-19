using University.Models;

namespace University.DAL
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Entities { get; }

        void Delete(T entity);
        IEnumerable<T> GetAllItem();
        Student GetByID(T entity);
        void Insert(T entity);
        void Save();
        void Update(T entity);
    }
}