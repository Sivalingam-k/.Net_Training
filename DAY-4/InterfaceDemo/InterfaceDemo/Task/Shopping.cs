using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo.Task
{
    internal class Shopping
    {
        public static void Main(String[] args)
        {
            Shop shop = new Shop();
            shop.shopName = "MSI";
            shop.product_name = "MSI Thin 15";
            shop.product_price = 52000;
            shop.product_category = "Gaming Laptop";
            shop.outlet_name = "MSI Factory";
            shop.outlet_city = "Thaiwanese";
            shop.outlet_location = "China";

           Console.WriteLine( shop.getProductDetails());
           Console.WriteLine( shop.getOutletDetails());
        }
    }
}
