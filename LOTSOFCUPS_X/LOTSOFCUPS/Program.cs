using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

string connectionString = File.ReadAllText("C:/revature/richard-book-db.txt");


using SqlConnection connection = new(connectionString);
connection.Open();

namespace LOTSOFCUPS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Product cup = new Product();

            Console.WriteLine("Hello World");
            Console.WriteLine("Welcome to LotsOfCups");
            Console.WriteLine("Please select from the following" );//want to try to add an index to select items
            Console.ReadLine();
        }
    }
}