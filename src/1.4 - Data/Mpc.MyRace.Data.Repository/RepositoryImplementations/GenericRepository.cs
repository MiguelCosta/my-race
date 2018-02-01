namespace Mpc.MyRace.Data.Repository.RepositoryImplementations
{
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Linq;
    using System.Threading.Tasks;
    using System;
    using Microsoft.EntityFrameworkCore;
    using Mpc.MyRace.Domain.Core.RepositoryInterfaces;

    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private DbSet<T> objectSet;
        private DbContext dbContext;

        public GenericRepository(DbContext dbContext)
        {
            this.objectSet = dbContext.Set<T>();
            this.dbContext = dbContext;
        }

        public void Add(T entity)
        {
            this.objectSet.Add(entity);
        }

        public void Attach(T entity)
        {
            this.objectSet.Attach(entity);
            this.dbContext.Entry(entity).State = EntityState.Modified;
        }

        public async Task<int> CountAsync()
        {
            return await this.objectSet
                .CountAsync()
                .ConfigureAwait(false);
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>> condition)
        {
            return await this.objectSet
                .CountAsync(condition)
                .ConfigureAwait(false);
        }

        public void Delete(T entity)
        {
            this.objectSet.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await this.objectSet
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> GetAllAsync(params string[] includes)
        {
            var query = this.objectSet
                .AsNoTracking()
                .AsQueryable();

            includes
                .ToList()
                .ForEach(x => query = query.Include(x));

            return await query
                .AsNoTracking()
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> condition)
        {
            return await this.objectSet
                .Where(condition)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> condition, params string[] includes)
        {
            var query = this.objectSet
                .AsNoTracking()
                .AsQueryable();

            includes
                .ToList()
                .ForEach(x => query = query.Include(x));

            return await query
                .Where(condition)
                .ToListAsync()
                .ConfigureAwait(false);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> condition)
        {
            return await this.objectSet
                .AsNoTracking()
                .FirstOrDefaultAsync(condition)
                .ConfigureAwait(false);
        }

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> condition, params string[] includes)
        {
            var query = this.objectSet
                .AsNoTracking()
                .AsQueryable();

            includes
                .ToList()
                .ForEach(x => query = query.Include(x));

            return await query
                .Where(condition)
                .FirstOrDefaultAsync(condition)
                .ConfigureAwait(false);
        }
    }
}
