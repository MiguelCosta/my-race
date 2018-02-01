namespace Mpc.MyRace.Domain.Core.RepositoryInterfaces
{
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using System;

    public interface IGenericRepository<T>
    {
        Task<T> GetSingleAsync(Expression<Func<T, bool>> condition);

        Task<T> GetSingleAsync(Expression<Func<T, bool>> condition, params string[] includes);

        void Add(T entity);

        void Delete(T entity);

        void Attach(T entity);

        Task<IEnumerable<T>> GetAllAsync();

        Task<IEnumerable<T>> GetAllAsync(params string[] includes);

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> condition);

        Task<IEnumerable<T>> GetAllAsync(Expression<Func<T, bool>> condition, params string[] includes);

        Task<int> CountAsync();

        Task<int> CountAsync(Expression<Func<T, bool>> condition);
    }
}
