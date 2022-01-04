using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopApp.Logic;

namespace CoffeeShopApp.DataInfrastructure
{

    public interface IRepository
    {
        IEnumerable<Location> GetAllLocations();
        IEnumerable<Order> GetAllOrders();
        int CreateNewCustomer();
        int UpdateCustomer();
        int DeleteCustomer();
        int Inventory();
        int UpdateInventory();
        int DeleteInventory();



    }
}
