using ApplicationBusiness;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Repository
{
    public class BrandRepository : IRepository<Brand>
    {
        private readonly AppDbContext _dbContext;

        public BrandRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Brand brand)
        {
            var brandModel = new BrandModel(){ Name = brand.Name };

            await _dbContext.Brands.AddAsync(brandModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Brand>> GetAllAsync()
            => await _dbContext.Brands
                .Select(b => new Brand{Id = b.Id,Name = b.Name}).ToListAsync(); 

        public async Task<Brand> GetByIdAsync(int id)
        {
            var brandModel = await _dbContext.Brands.FindAsync(id);

            return new Brand
            {
                Id = brandModel.Id,
                Name = brandModel.Name
            };
        }
    }
}
