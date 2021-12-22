// See https://aka.ms/new-console-template for more information

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;

//



namespace CoffeeShopApp.App
{
    public class Program
    {

        //public void sqlConnection()
        //{
        //    //Add connection to database here
        //    string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");
        //    using SqlConnection connection = new(connectionString);
        //    connection.Open();

        //need to add exception for connection issue
        //}

        public static void Main(string[] args)
        {
          
            ////Reading to database using DataReader
            //static void HasRows(SqlConnection connection)
            //{
            //    using (connection)
            //    {
            //        SqlCommand command = new SqlCommand(
            //          "SELECT Store, CategoryName FROM Categories;",
            //          connection);
            //        connection.Open();

            //        SqlDataReader reader = command.ExecuteReader();

            //        if (reader.HasRows)
            //        {
            //            while (reader.Read())
            //            {
            //                Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
            //                    reader.GetString(1));
            //            }
            //        }
            //        else
            //        {
            //            Console.WriteLine("If you reading this its connected.");
            //        }
            //        reader.Close();
            //    }
            //}




            Console.WriteLine("Hello, CoffeeShop!");

            //version1
            //string nameFirst = ""; 
            //string nameLast = "";

            //Version 3
            Customer newCustomer = new Customer();
            newCustomer.CustomerName();

            //Version3
            //Order newOrder = new Order();
            //newOrder.CustomerOrder();

            //version 4 12/21
            Order newOrder = new Order();
            newOrder.Ordering();


            //version 1
            //Console.WriteLine("Enter First Name" + nameFirst);
            //Console.ReadLine();

            //Console.WriteLine("Enter Last Name" + nameLast);
            //Console.ReadLine();


            //Version 2
            //Order newOrder = new Order();
            //newOrder.OrderNumber();


            ////Loop to keep letting customer shop
            //while (customerStillOrdering)
            //{
            //    Console.Clear();
            //    Console.WriteLine("Would you like to order another coffee?");
            //    Console.WriteLine("Would you like your total");
            //}

        
        }


    }
}