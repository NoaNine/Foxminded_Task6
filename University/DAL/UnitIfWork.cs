using System.Data.Entity;
using System.Data.Entity.Validation;
using University.DAL.Interface;
using University.Models;
using University.DAL;

namespace ContosoUniversity.DAL
{
    public class UnitOfWork : IDisposable, IUnitOfWork
    {
        private readonly UniversityContext _context;
        private string _errorMessage = string.Empty;
        private bool _disposed = false;
        private Dictionary<Type, object> _repositories;

        public UnitOfWork(UniversityContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IRepository<TEntity> GetRepository<TEntity>() where TEntity : class
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<Type, object>();
            }
            var type = typeof(TEntity);
            if (!_repositories.ContainsKey(type))
            {
                _repositories[type] = new Repository<TEntity>(_context);
            }

            return (IRepository<TEntity>)_repositories[type];
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        _errorMessage = _errorMessage +
                            $"Property: {validationError.PropertyName} Error: {validationError.ErrorMessage} {Environment.NewLine}";
                    }
                }
                throw new Exception(_errorMessage, dbEx);
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
                }
            }
            _disposed = true;
        }
    }
}