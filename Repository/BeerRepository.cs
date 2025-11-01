﻿

using ApplicationBusiness;
using Data;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace Repository
{
    public class BeerRepository : IRepository<Beer>
    {
        private readonly AppDbContext _dbContext;

        public BeerRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(Beer beer)
        {
            var beerModel = new Model.BeerModel()
            {
                Name = beer.Name,
                BrandId = beer.BrandId
            };

            await _dbContext.AddAsync(beerModel);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Beer>> GetAllAsync()
            => await _dbContext.Beers.Select(beerModel => new Beer
            {
                Id = beerModel.Id,
                Name = beerModel.Name,
                BrandId = beerModel.BrandId,
                Alcohol = beerModel.Alcohol
            }).ToListAsync();

        public async Task<Beer> GetByIdAsync(int id)
        {
            var beerModel = await _dbContext.Beers.FindAsync(id);
            return new Beer
            {
                Id = beerModel.Id,
                Name = beerModel.Name,
                BrandId = beerModel.BrandId,
                Alcohol = beerModel.Alcohol
            };
        }

        public async Task EditAsync(Beer beer)
        {
            var beerModel = await _dbContext.Beers.FindAsync(beer.Id);
            if (beerModel != null)
            {
                beerModel.Name = beer.Name;
                beerModel.BrandId = beer.BrandId;
                beerModel.Alcohol = beer.Alcohol;

                _dbContext.Entry(beerModel).State = EntityState.Modified;
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(int id)
        {
            var beerModel = await _dbContext.Beers.FindAsync(id);
            if (beerModel != null)
            {
                _dbContext.Beers.Remove(beerModel);
                await _dbContext.SaveChangesAsync();
            }
        }
    }
}
