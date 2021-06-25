using System;

namespace ShopApplication.Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Shopping shopping = new Shopping();

            string command = "";

            System.Console.WriteLine("Possible commands: Exit, Buy, Topup");
            while (command != "Exit")
            {               
                Console.WriteLine("");                
                 command = Console.ReadLine(); //kol wailas, tol nuskaito viska is konsoles i kintamaji (command) 

                if (command.StartsWith("Buy"))
                {                     
                    string itemName = command.Split(' ')[1];
                    string quantity = command.Split(' ')[2];
                    int parsedQuantity = Int32.Parse(quantity);
                    shopping.Buy(itemName, parsedQuantity);
                }
                if (command.StartsWith("Topup"))
                {
                    string value = command.Split(' ')[1];
                    shopping.Topup(value);
                }
            }
        }
    }
}



