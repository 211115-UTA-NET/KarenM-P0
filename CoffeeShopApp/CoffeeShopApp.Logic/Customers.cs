using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Logic
{
    internal class Customers
    {
        string customer { get; set; }
        string name { get; set; }

    }
}
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
        // //Add excetion here
        //try
        //{
        string customername = null;
        Console.WriteLine("What's your first name?");
        customername = Console.ReadLine();
        Console.WriteLine("What's your last name?");
        customername = Console.ReadLine();
        //}
        //catch(cexception)
        //{
        //Console.WriteLine("Invalid name input, please try again")
        //CustomerName();
        //return;
        //}   
    }



}
}