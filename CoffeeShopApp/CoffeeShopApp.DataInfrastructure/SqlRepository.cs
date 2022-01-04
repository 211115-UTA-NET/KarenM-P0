using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.DataInfrastructure
{
    internal interface SqlRepository
    {
    }
}


////comment out for now
//    public class SqlRepository : Repository
//{
//    private readonly string _connectionString;

//    public SqlRepository(string connectionString)
//    {
//        _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
//    }

//}