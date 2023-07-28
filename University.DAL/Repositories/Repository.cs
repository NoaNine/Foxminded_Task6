using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace University.DAL.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly UniversityContext _dbContext;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(UniversityContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<TEntity>();
        }

        public IEnumerable<TEntity> GettAll()
        {
            return _dbContext.Set<TEntity>().ToList();
        }

        public IEnumerable<TEntity> GetAll(Expression<Func<TEntity, bool>> filter)
        {
            return _dbSet.Where(filter).ToList();
        }

        public IQueryable<TEntity> GetAllQuery()
        {
            return _dbSet.AsNoTracking();
        }

        public TEntity GetByID(TEntity entity)
        {
            return _dbSet.Find(entity);
        }

        public TEntity Insert(TEntity entity)
        {
            _dbSet.Add(entity);
            _dbContext.SaveChanges();
            return entity;
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public TEntity Update(TEntity entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return entity;
        }
    }
}