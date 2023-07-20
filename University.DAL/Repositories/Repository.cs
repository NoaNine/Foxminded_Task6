using System.Data.Entity;
using System.Linq.Expressions;

namespace University.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UniversityContext _dbContext;
        private readonly IDbSet<TEntity> _dbSet;

        public Repository(UniversityContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GettAll()
        {
            return _dbSet.ToList();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public IQueryable<TEntity> GetAllQuery()
        {
            return null; // add
        }

        public TEntity GetByID(TEntity entity)
        {
            return _dbSet.Find(entity);
        }

        public TEntity Insert(TEntity entity)
        {
            return _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
            var input = _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
            return input;
        }
    }
}