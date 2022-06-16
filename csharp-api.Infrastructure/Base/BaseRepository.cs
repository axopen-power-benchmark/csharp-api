using csharp_api.Infrastructure.Database;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace csharp_api.Infrastructure.Base
{
    public class BaseRepository<TEntity, TContext> : IBaseRepository<TEntity> 
        where TEntity : class
        where TContext : CoreDbContext
    {
        protected readonly TContext _dbContext;

        public BaseRepository(TContext context)
        {
            _dbContext = context;
        }

        public async Task<List<TEntity>> GetAllAsync()
        {
            try
            {
                return await _dbContext.Set<TEntity>().AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Impossible de récupérer les entités: {ex.Message}");
            }
        }

        public async Task<List<TEntity>> GetAllAsync(Expression<Func<TEntity, bool>> where)
        {
            try
            {
                return await _dbContext.Set<TEntity>().Where(where).AsNoTracking().ToListAsync();
            }
            catch (Exception ex)
            {
                throw new Exception($"Impossible de récupérer les entités: {ex.Message}");
            }
        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {
                return await _dbContext.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Impossible de récupérer l'entité: {ex.Message}");
            }
        }

        public async void SaveAsync(TEntity entity)
        {
            try
            {
                await _dbContext.Set<TEntity>().AddAsync(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Impossible de sauvegarder l'entité: {ex.Message}");
            }
        }

        public void Update(TEntity entity)
        {
            try
            {
                _dbContext.Set<TEntity>().Update(entity);
            }
            catch (Exception ex)
            {
                throw new Exception($"Impossible de mettre à jour l'entité: {ex.Message}");
            }
        }
    }
}
