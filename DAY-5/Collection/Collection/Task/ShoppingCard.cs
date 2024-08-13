using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection.Task
{
    internal class ShoppingCard
    {
        //static void Main(string[] args)
        //{

            

            //Product p1, p2, p3, p4;
            //p1 = new Product
            //{
            //    Id = 100,
            //    Name = "Bag",
            //    price = 200
            //};
            //p2 = new Product
            //{
            //    Id = 200,
            //    Name = "Shirt",
            //    price = 2050
            //};
            //p3 = new Product
            //{
            //    Id = 300,
            //    Name = "T-shirt",
            //    price = 500
            //};
            //p4 = new Product
            //{
            //    Id = 400,
            //    Name = "Pant",
            //    price = 700
            //};

            //List<Product> products = new List<Product> { p1, p2, p3, p4 };
            //List<Product> cartlist = new List<Product>();

            //for(int i=0;i<products.Count;i++ )
            //{
            //    Product product= products[i];
            //    if (product.price > 300)
            //    {
            //        cartlist.Add(product);
            //    }
            //}
            //for (int i = 0; i < cartlist.Count; i++)
            //{
            //    Product product = cartlist[i];
            //    Console.WriteLine(product.Name + " " + product.price);
            //}

            //LINQ:
            //List<int> ints = new List<int> { 10, 20, 33, 40, 55 };
            //List<int> evenlist = new List<int>();

            //evenlist = (from item in ints where (item % 2 == 0) select item).ToList();

            //foreach (int i in evenlist)
            //{
            //    Console.WriteLine(i);
            //}


            //List<string> products = new List<string>() { "Butter", "Bread", "Milk", "Cheese" };
            //List<string> prolist = new List<string>();
            //Console.WriteLine("Enter the Product Name :");
            //string product = Console.ReadLine();
            //prolist = (from pro in products where (pro.Equals(product, StringComparison.OrdinalIgnoreCase)) select pro).ToList();

            //if (products.Contains(product, StringComparer.OrdinalIgnoreCase))
            //{
            //    foreach (string i in prolist)
            //    {
            //        Console.WriteLine(i + " " + " is Available in Products");

            //    }
            //}
            //else
            //{
            //    Console.WriteLine("This product is Not Available");
            //}

            //    List<int> price = new List<int>() { 100, 200, 300, 400 };

            //    Console.WriteLine("Shopping List :");
            //    Console.WriteLine("==============================");
            //    Console.WriteLine();
            //    Console.WriteLine("Products :" + "Price");
            //    Console.WriteLine("--------------------------");
            //    for (int i = 0; i < products.Count; i++)
            //    {
            //        Console.WriteLine(products[i] + ":" + price[i]);
            //    }

            //    Console.WriteLine();
            //    string flag = "";
            //    Console.Write("Select The option : ");
            //    Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
            //    int option = Convert.ToInt32(Console.ReadLine());
            //    while (option > 0)
            //    {
            //        if (option == 1)
            //        {
            //            Console.WriteLine("Do you want to add the Product (Y/N) :");
            //            flag = Console.ReadLine();
            //            if (flag == "Y" || flag == "y")
            //            {
            //                Console.WriteLine("Enter Product Name : ");
            //                string item = Console.ReadLine();
            //                Console.WriteLine("Enter Product Price : ");
            //                int amount = Convert.ToInt32(Console.ReadLine());
            //                products.Add(item);
            //                price.Add(amount);
            //                Console.Write("Do You Want To Continue : ");
            //                flag = Console.ReadLine();
            //                if (flag == "N" || flag == "n")
            //                {
            //                    Console.Write("Select The option : ");
            //                    Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
            //                    option = Convert.ToInt32(Console.ReadLine());
            //                }

            //            }
            //        }
            //        else if (option == 2)
            //        {
            //            Console.WriteLine("Do you want to Update the Product (Y/N) :");
            //            flag = Console.ReadLine();
            //            while (flag == "Y" || flag == "y")
            //            {
            //                Console.WriteLine("Product Details :");

            //                Console.Write("Print the Index to Update :");
            //                int no = Convert.ToInt32(Console.ReadLine());
            //                Console.Write("Print the Item to Update :");
            //                string items = Console.ReadLine();
            //                Console.Write("Print the price to Update :");
            //                int p = Convert.ToInt32(Console.ReadLine());
            //                products[no]= items;
            //                price[no] = p;
            //                Console.WriteLine(items + "  is Updated successfully");
            //                Console.Write("Do You Want To Update Other  (Y/N): ");
            //                flag = Console.ReadLine();
            //                if (flag == "N" || flag == "n")
            //                {
            //                    Console.Write("Select The option : ");
            //                    Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
            //                    option = Convert.ToInt32(Console.ReadLine());
            //                }
            //            }

            //        }
            //        else if (option == 3)
            //        {
            //            Console.WriteLine("Do you want to Remove the Product (Y/N) :");
            //            flag = Console.ReadLine();
            //            if (flag == "Y" || flag == "y")
            //            {
            //                Console.Write("Print the Index to Remove :");
            //                int pro = Convert.ToInt32(Console.ReadLine());

            //                products.RemoveAt(pro);
            //                price.RemoveAt(pro);
            //                Console.WriteLine(pro + " index  is Deleted Successfully!!");
            //                Console.Write("Do You Want To Delete Other (Y/N) : ");
            //                flag = Console.ReadLine();
            //                if (flag == "N" || flag == "n")
            //                {
            //                    Console.Write("Select The option : ");
            //                    Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
            //                    option = Convert.ToInt32(Console.ReadLine());
            //                }
            //            }

            //        }
            //        else if (option == 4)
            //        {
            //            for (int i = 0; i < products.Count; i++)
            //            {
            //                Console.WriteLine(products[i] + ":" + price[i]);
            //            }
            //            Console.Write("Do You Want To See the lis Again ? (Y/N) : ");
            //            flag = Console.ReadLine();
            //            if (flag == "N" || flag == "n")
            //            {
            //                Console.Write("Select The option : ");
            //                Console.WriteLine(" 1.Add \n 2.Update \n 3.Remove \n 4.Show the List ");
            //                option = Convert.ToInt32(Console.ReadLine());
            //            }
            //        }
            //        else
            //        {

            //            Console.WriteLine("Invalid Option !!");
            //        }
            //    }

        //}
    }
    }

