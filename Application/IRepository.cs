﻿
namespace Application
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T beer);
    }
}
