﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Logic
{
    public class Customers
    {
        //Version 2

        private int customerID { get; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        public string email { get; set; }
        private string phone { get; set; }
        //private customerID {get;}
        //private string customerName;
        //private string firstName { get { return firstName; } set { firstName = value; } }
        //private string lastName { get { return lastName; } set { lastName = value; } }   
        //private string customerName { get { return customerName; } set { customerName = value; } }
        //private string email { get { return email; } set { email = value; } }
        //private string phone { get { return phone; } set { phone = value; } }

        //Building a Customer constructor
        //Version 2 goes with Version 3 of Program
        public Customers(int customerID, string firstName, string lastName, string email, string phone)
        {
            customerID = customerID;
            firstName = firstName;
            lastName = lastName;
            email = email;
            phone = phone;
        }

        public Customers()
        {
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