

using Entities;

namespace ApplicationBusiness
{
    public class AddBeer
    {
        private readonly IRepository<Beer> _beerRepository;

        public AddBeer(IRepository<Beer> beerRepository)
        {
            _beerRepository = beerRepository;
        }

        public async Task ExecuteAsync(Beer beer)
        {
            if(string.IsNullOrEmpty(beer.Name))
            {
                throw new ArgumentException("El nombre de la cerveza es obligatoria");
            }

            await _beerRepository.AddAsync(beer);
        }
    }
}
