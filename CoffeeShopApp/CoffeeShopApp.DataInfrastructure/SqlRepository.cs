using Microsoft.Data.SqlClient;
using CoffeeShopApp.Logic;
using System.Data.SqlClient;

namespace CoffeeShopApp.DataInfrastructure
{
    public class SqlRepository : IRepository
    {
        private readonly string? _connectionString;

        public SqlRepository(string connectionString)
        {
            _connectionString = connectionString ?? throw new ArgumentNullException(nameof(connectionString));
        }


        public Task<List<Locations>> GetAllLocations()
        {
            List<Locations> locations = new List<Locations>();
            using SqlConnection connection = new(_connectionString);
            connection.Open();
            using SqlCommand cmd = new SqlCommand(
                //0         1
                //id       location
                @"SELECT * FROM Store", connection);
            using SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                locations.Add(new(reader.GetInt32(0), reader.GetString(1)));
            }
            connection.Close();
            return null;
        }

        public Task<List<Order>> GetAllOrders()
        {
            throw new NotImplementedException();
        }
    }
}