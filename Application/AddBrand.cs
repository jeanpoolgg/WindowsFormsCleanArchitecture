﻿using Entities;

namespace Application
{
    public class AddBrand
    {
        private readonly IRepository<Brand> _repository;

        public AddBrand(IRepository<Brand> repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Brand brand)
        {
            if(string.IsNullOrEmpty(brand.Name))
            {
                throw new ArgumentException("El nombre de la marca es obligatorio");
            }

            await _repository.AddAsync(brand);
        }
    }
}
