using csharp_api.Infrastructure.Base;
using System.Linq.Expressions;

namespace csharp_api.Applications.Base
{
    public class BaseService<TRepository, TEntity> : IBaseService<TEntity>
        where TRepository : IBaseRepository<TEntity>
        where TEntity : class
    {

        protected readonly TRepository _repository;

        public BaseService(TRepository repository)
        {
            _repository = repository;
        }
        public async Task<TEntity> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where)
        {
            return await _repository.GetAllAsync(where);
        }

        
    }
}
