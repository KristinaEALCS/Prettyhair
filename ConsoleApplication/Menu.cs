using PrettyHairLibrary;
using System;

namespace ConsoleApplication
{

    public class Menu
    { 
        private ProductTypeRepository pr;

        public Menu(ProductTypeRepository prodRep) {
            pr = prodRep;
        }

        public void PrintMenu()
        {
            Console.WriteLine("0. Close");
            Console.WriteLine("1. View all product types");
            Console.WriteLine("2. Update product.");
            Console.WriteLine("4. Show daily orders");
        }

        public void ViewProductTypes()
        {
            Console.Clear();
            HeadLine("Show all products");
            Console.WriteLine(pr.ViewAllProducts());
        }

        public void PrintUpdateOptions()
        {
            HeadLine("Update Option for ProductType");
            Console.WriteLine("0. Exit");
            Console.WriteLine("1. Change description");
            Console.WriteLine("2. Change price");
            Console.WriteLine("3. Change amount");
        }

        public void PrintUpdateAmountText()
        {
            HeadLine("Update amount by inputting a new value");
            Console.WriteLine("(*Note the value it cannot be below 0)");
        }

        public void PrintUpdatePriceText()
        {
            HeadLine("Update price by inputting a new value");
            Console.WriteLine("(*Note the value it cannot be below 0)");
        }

        public void HeadLine(string sr)
        {
            Console.WriteLine("*------------------" + sr + "------------------*");
        }
    }
}
