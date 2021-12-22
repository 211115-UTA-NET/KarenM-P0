// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;




namespace CoffeeShopApp.App
{
    public class Program
    {



    public static void Main(string[] args)
        {
          
            Console.WriteLine("Hello, CoffeeShop!");

            //version1
            //string nameFirst = ""; 
            //string nameLast = "";

            //Version 3
            Customer newCustomer = new Customer();
            newCustomer.CustomerName();

            //Order newOrder = new Order();
            //newOrder.CustomerOrder();

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

            //
            //public void sqlConnection()
            //{
            //    //Add connection to database here
            //    string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");
            //    using SqlConnection connection = new(connectionString);
            //    connection.Open();
            //}
        }


    }
}