//12/21/2021 Could make a Person class the Customer could derive from.
//That will give me the option to add employees as well.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.App
{
    public class Customer
    {
        //Version 1- 12/20/21 first attempt to get program to call this
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
        
        //Version 2
        private string firstName;
        private string lastName;

        //Building a Customer constructor
        //Version 2 goes with Version 3 of Program
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
      

        //version 1
        //public void CustomerName()
        //{
        //    Console.WriteLine($"{firstName} {lastName}");
        //}
    }
}
