using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace EWallet.ApplicationCore.Interfaces.Persistance
{
    public interface IAsyncRepository<T> where T: class
    {
        Task<T> GetByIdAsync(int Id);
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<IReadOnlyList<T>> GetAllByIdAsync(int Id);
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(T entity);
    }
}
