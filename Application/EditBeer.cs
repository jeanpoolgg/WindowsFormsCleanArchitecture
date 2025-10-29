

using Entities;

namespace ApplicationBusiness
{
    public class EditBeer
    {
        private readonly IRepository<Beer> _repository;

        public EditBeer (IRepository<Beer> repository)
        {
            _repository = repository;
        }

        public async Task ExecuteAsync(Beer beer)
        {
            if(string.IsNullOrEmpty(beer.Name))
            {
                throw new ArgumentException("El nombre de la cerveza es obligatorio");
            }

            if(await _repository.GetByIdAsync(beer.Id) == null)
            {
                throw new ArgumentException("Cerveza no existe");
            }

            await _repository.EditAsync(beer);   
        }

    }
}
