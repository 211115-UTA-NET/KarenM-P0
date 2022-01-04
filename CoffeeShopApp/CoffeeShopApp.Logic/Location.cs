using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Logic
{
    public class Location
    {
        public int locationId { get;}
        public Location(int ID, string locationName)
        {
            locaionId = ID;
            locationName = locationName;

        }
    }
}
