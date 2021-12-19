using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOTSOFCUPS
{
    public class Product
    {
        private int productID { get; set; }
        string? cupName { get; set; }
        string? cupColor { get; set; }
        decimal price { get; set; }
        int size { get; set; }

        public Product()
        {
            this.color ="colors";
            this.size ="sizes";
            this.price = 0;
        }
        public Product (string cupName, string cupColor, int size, decimal price )
	    {
            SmartCup = cupName;
            Color = cupColor;
            Size = size;
            Cost = price;
	    }
    }
 
  
}
