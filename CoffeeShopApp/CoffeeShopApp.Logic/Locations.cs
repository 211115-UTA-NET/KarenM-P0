using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopApp.Logic
{
    public class Locations
    {
        private int locaionId;

        private int locationId { get;}
        public Locations(int ID, string locationName)
        {
            locaionId = ID;
            locationName = locationName;

        }
    }
}
