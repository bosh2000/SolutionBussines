using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SolutionBussines.DBRepository.Interfaces;
using System.Linq.Expressions;

namespace SolutionBussines.DBRepository.Impl
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly SBDbContext _context;
        protected readonly IMapper _mapper;
        public readonly DbSet<T> DBSet;

        public RepositoryBase(SBDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
            DBSet = _context.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            var result = await DBSet.AddAsync(entity);
            await SaveAsync();
            return result.Entity;
        }

        public async Task DeleteAsync(T entity)
        {
            DBSet.Remove(entity);
            await SaveAsync();
        }

        public async Task SaveAsync() => await _context.SaveChangesAsync();

        public async Task<List<T>> ConditionToListAsync(Expression<Func<T, bool>> expression, bool disableTracking = true)
        {
            _context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            IQueryable<T> query = DBSet;
            if (!disableTracking)
                query = query.Where(expression).AsNoTracking();
            else
                query = query.Where(expression);
            return await query.ToListAsync();
        }

        public async Task<T> FirstOfDefaultAsync(Expression<Func<T, bool>> expression)
        {
            IQueryable<T> query = DBSet;
            query = query.Where(expression);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<List<T>> ToListAsync()
        {
            return await DBSet.ToListAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.ChangeTracker.AutoDetectChangesEnabled = true;
            DBSet.Attach(entity).State = EntityState.Modified;
            DBSet.Update(entity);
            await _context.SaveChangesAsync();
            _context.ChangeTracker.AutoDetectChangesEnabled = false;
        }
    }
}