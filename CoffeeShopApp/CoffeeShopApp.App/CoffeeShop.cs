using CoffeeShopApp.DataInfrastructure;

namespace CoffeeShopApp.App
{
    public class CoffeeShop
    {
        public IRepository _repository;
        
        public CoffeeShop(IRepository repository)
        {
            _repository = repository;

        }
    }

    public interface IRepository
    {
    }
}
