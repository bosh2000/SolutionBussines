using System.Linq.Expressions;

namespace SolutionBussines.DBRepository.Interfaces
{
    public interface IRepositoryBase<T> where T : class

    {
        Task<List<T>> ConditionToListAsync(Expression<Func<T, bool>> expression, bool disableTracking = true);

        Task<List<T>> ToListAsync();

        Task<T> FirstOfDefaultAsync(Expression<Func<T, bool>> expression);

        Task<T> CreateAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);

        Task SaveAsync();
    }
}