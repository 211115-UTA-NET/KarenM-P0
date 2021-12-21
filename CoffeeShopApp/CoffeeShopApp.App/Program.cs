// See https://aka.ms/new-console-template for more information

using System.Data.SqlClient;

namespace CoffeeShopApp.App
{
    public class Program
    {

        //Add connection to database here
        string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");
       

    public static void Main(string[] args)
        {
          
            Console.WriteLine("Hello, CoffeeShop!");

            //version1
            //string nameFirst = ""; 
            //string nameLast = "";


            Customer newCustomer = new Customer();
            newCustomer.CustomerName();

            Order newOrder = new Order();
            newOrder.CustomerOrder();


            //version 1
            //Console.WriteLine("Enter First Name" + nameFirst);
            //Console.ReadLine();

            //Console.WriteLine("Enter Last Name" + nameLast);
            //Console.ReadLine();


            //Version 2
            //Order newOrder = new Order();
            //newOrder.OrderNumber();


        }


    }
}