using System.Linq.Expressions;

namespace csharp_api.Applications.Base
{
    public interface IBaseService<TEntity> where TEntity : class
    {
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAllAsync();
        Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where);
    }
}
