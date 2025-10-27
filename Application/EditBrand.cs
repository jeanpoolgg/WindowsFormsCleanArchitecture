using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class EditBrand
    {
        private readonly IRepository<Brand> _repositoryBrand;

        public EditBrand(IRepository<Brand> repositoryBrand)
        {
            _repositoryBrand = repositoryBrand;
        }

        public async Task ExecuteAsync(Brand brand)
        {
            if(string.IsNullOrEmpty(brand.Name))
            {
                throw new Exception("El nombre de la marca es obligatorio");
            }

            if(await _repositoryBrand.GetByIdAsync(brand.Id) == null)
            {
                throw new Exception("La marca no existe");
            }

            // Lógica para editar la marca
            await _repositoryBrand.EditAsync(brand);
        }       
    }
}
