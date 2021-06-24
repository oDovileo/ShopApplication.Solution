using System;

namespace ShopApplication.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping shopping = new Shopping();
            string command = "";

            while (command != "exit")
            {               
                Console.WriteLine("");                
                 command = Console.ReadLine(); //kol wailas, tol nuskaito viska is konsoles i kintamaji (command) 

                if (command.StartsWith("Buy"))
                {
                    var itemName = command.Split(' ')[1];
                    shopping.Buy(itemName);
                }
                if (command.StartsWith("Topup"))
                {
                    var value = command.Split(' ')[1];
                    shopping.Topup(value);
                }
            }
        }
    }
}



