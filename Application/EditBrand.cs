using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public class EditBrand
    {
        private readonly IRepository<Entities.Brand> _repositoryBrand;

        public EditBrand(IRepository<Entities.Brand> repositoryBrand)
        {
            _repositoryBrand = repositoryBrand;
        }

        public async Task Execute(Entities.Brand brand)
        {
            // Validaciones
            if (brand == null)
            {
                throw new ArgumentNullException(nameof(brand), "La marca no puede ser nula.");
            }

            if (brand.Id <= 0)
            {
                throw new ArgumentException("El ID de la marca debe ser mayor que cero.", nameof(brand.Id));
            }

            if (string.IsNullOrWhiteSpace(brand.Name))
            {
                throw new ArgumentException("El nombre de la marca no puede estar vacío.", nameof(brand.Name));
            }

            // Lógica para editar la marca
            await _repositoryBrand.EditAsync(brand);
        }       
    }
}
