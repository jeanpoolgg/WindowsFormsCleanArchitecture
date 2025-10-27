
namespace ApplicationBusiness
{
    public interface IRepository<T>
    {
        Task<T> GetByIdAsync(int id);

        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T item);

        public Task EditAsync(T item);

        public Task DeleteAsync(int id);
    }
}
