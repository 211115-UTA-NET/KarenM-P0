

namespace LotsOfCups2
{
    public class Ordering
    {
        /*       public Order()
               {
                   InitializeComponent();
             }  */

        int cupsOrdered;
        const int productNumber = 3;
        Product[] products = new Product[productNumber];
        private Cart(int productNumber) //Error CS1520
        {
            products[0] = new Product("Purple 8oz SmartMug", 50);
            products[1] = new Product("Purple 20oz SmartMug", 100);
            products[2] = new Product("Black 8oz SmartMug", 50);
            products[3] = new Product("Black 20oz SmartMug", 100);

            for (int i = 0; i < productNumber; i++)
            {

            }
        }
    }
}
