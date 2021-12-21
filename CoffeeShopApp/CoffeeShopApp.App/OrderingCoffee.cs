//Need to change this to order. Size will be in class Coffee 12/20/21
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.App
{


    public class Order 
    {
        private readonly int Small;
        private readonly int Medium;
        private readonly int Large;

        //public int Small { get { return Small  } }
        //public int Medium { get { return Medium; } }
        //public int Large { get { return Large; } }


        //Build a constructor for order
        public Order(int Small, int Meduim, int Large)
        {
            this.Small = Small;
            this.Medium = Meduim;  
            this.Large = Large;
        }
        public Order()
        {
            Small = 0;
            Medium = 0; 
            Large = 0;
        }
        public void CustomerOrder()
        {
            string customerOrder;
            Console.WriteLine("What would like to order");
            Console.WriteLine("Small, Meduim, Large");
            customerOrder = Console.ReadLine();

        }


     
        

        ////version 2
        //private string OrderNumber;
        //private string OrderNumber()
        //{ get{ return OrderNumber};
        //{ set{ Order = value};
        

        //private int Id;
        //public int Id
        //{
        //    get { return id; }
        //    set { this.id = value; }
        //}

        //public OrderNumber ()
        //{
        //    this.Id= 0;
        //    this.Order = null;
        //}
        //public void CustomerOrder()
        //{
        //    string customerorder;
        //    Console.WriteLine("What would you like to order?");
        //    customerorder = Console.ReadLine();

        //}
        //internal void Order()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
