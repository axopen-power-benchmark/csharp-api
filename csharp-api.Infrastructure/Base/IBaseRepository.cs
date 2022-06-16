using System.Linq.Expressions;

namespace csharp_api.Infrastructure.Base
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where);

        void SaveAsync(TEntity entity);
        void Update(TEntity entity);
    }
}
