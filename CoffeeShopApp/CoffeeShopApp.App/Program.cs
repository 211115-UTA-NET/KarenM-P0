﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using CoffeeShopApp.DataInfrastructure;
using CoffeeShopApp.Logic;



namespace CoffeeShopApp.App
{
    public class Program
    {
        string connectionString = File.ReadAllText("C:/Users/mkare_wyte20y/Revature/DQL_Database.txt");
        
        //need to add exception for connection issue
        
      
        public static void Main(string[] args)
        {
           
            //IRepository repository = new SqlRepository(connectionString);//need to fix

            ////Reading to database using DataReader
            static void HasRows(SqlConnection connection)
            {
                using (connection)
                {
                    SqlCommand command = new SqlCommand(
                      "SELECT Store, CategoryName FROM Categories;",
                     connection);
                    connection.Open();

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Console.WriteLine("{0}\t{1}", reader.GetInt32(0),
                                reader.GetString(1));
                        }
                    }
                    else
                   {
                        Console.WriteLine("If you reading this its connected.");
                    }
                    reader.Close();
                }
            }
            Console.WriteLine("Hello, CoffeeShop!");



            //Version 3
            Customers newCustomer = new Customers();
            newCustomer.CustomerName();


            //version 4 12/21
            Order newOrder = new Order();
            newOrder.Ordering();

        }


    }
}