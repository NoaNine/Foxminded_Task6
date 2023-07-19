using System.Data.Entity;
using System.Linq.Expressions;
using University.DAL.Interface;

namespace University.DAL
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
            return null;
        }

        public TEntity GetByID(TEntity entity)
        {
            return _dbSet.Find(entity);
        }

        public void Insert(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _dbContext.Entry(entity).State = EntityState.Modified;
        }
    }
}