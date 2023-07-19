using System.Data.Entity;
using University.Models;

namespace University.DAL
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly UniversityContext _dbContext;
        private IDbSet<T> _dbSet => _dbContext.Set<T>();
        public IQueryable<T> Entities => _dbSet;

        public GenericRepository(UniversityContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<T> GetAllItem()
        {
            return null;
        }

        public Student GetByID(T entity)
        {
            return null;
        }

        public void Insert(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(T entity)
        {

        }

        public void Save()
        {

        }
    }
}