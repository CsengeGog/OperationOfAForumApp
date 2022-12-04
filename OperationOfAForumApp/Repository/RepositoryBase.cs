using Microsoft.EntityFrameworkCore;
using OperationOfAForumApp.Data;
using System.Linq.Expressions;

namespace OperationOfAForumApp.Repository
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected DataContex RepositoryContext { get; set; }

        public RepositoryBase(DataContex repositoryContext)
        {
            RepositoryContext = repositoryContext;
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> expression) => RepositoryContext.Set<T>().Where(expression).AsNoTracking(); 
   
        public IQueryable<T> GetAll() => RepositoryContext.Set<T>().AsNoTracking();
        public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);

        public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);

        public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
    }
}
