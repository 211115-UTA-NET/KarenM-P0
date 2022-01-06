
using CoffeeShopApp.Logic;

namespace CoffeeShopApp.DataInfrastructure
{

    public interface IRepository
    {
        Task<List<Locations>> GetAllLocations();
        Task<List<Order>> GetAllOrders();
        //int CreateNewCustomer();
        //int UpdateCustomer();
        //int DeleteCustomer();
        //int Inventory();
        //int UpdateInventory();
        //int DeleteInventory();



    }
}
