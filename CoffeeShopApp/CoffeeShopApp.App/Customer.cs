using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.App
{
    public class Customer
    {
        //12/20/21 first attempt to get program to call this
        //public string nameFirst = "";
        //public string nameLast = "";
        ////public string nameFirst { get; private set; }
        ////public string nameLast { get; private set; }
        //public Customer(string nameFirst, string nameLast)
        //{
        //    this.nameFirst = nameFirst;
        //    this.nameLast = nameLast;
        //}

        //public Customer(string v)
        //{ 
        //    nameFirst = v;
        //    nameLast = v;


        //    throw new NotImplementedException();
        //}
        private string firstName;
        private string lastName;

        //Building a Customer constructor
        public Customer(string first, string last)
        {
            firstName = first;
            lastName = last;
        }
        public Customer()
        {
            firstName = "Coffee";
            lastName = "Shop";
            
        }
        public void CustomerName()
        {
            string customername = null;
            Console.WriteLine("Whats your name");
            customername = Console.ReadLine();
        }
      

        
        //public void CustomerName()
        //{
        //    Console.WriteLine($"{firstName} {lastName}");
        //}
    }
}
