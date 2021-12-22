//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CoffeeShopApp.App
//{
//    public class SqlRepository : Irepository
//    {
//        private readonly _connectionString;
//    }
//    public SqlRepositroy(string connectionString)
//    {
//        connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
//    }

//    public IEnumerable<Order>GetOrders(int quantity)
//    {
//        //Need to create a list for order
//        List<Order> orders = new List<Order>();
//        using SqlConnection connection = new(_connectionString);
//        connection.Open();
//    }
//}
