using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopApplication.Project
{
    class Shopping
    {
        public decimal Money { get; set; } = 10.00m;

        public List<Item> Items = new List<Item>()
        {
            new Item("Candy", 4),
            new Item("Book", 8),
            new Item("Juice", 2)
        };
                
        public bool Buy(string itemName)
        {
            Item item = Items.FirstOrDefault(i => i.Name == itemName); // is turimu item pasiima
            if (item == null)
            {
                Console.WriteLine("-- This item does not exist");
                return false;
            }
            else
            {
                if (Money >= item.Price)
                {
                    Money -= item.Price;
                    Console.WriteLine("-- " + itemName + "Bought");
                    return true;
                }
                else
                {
                    Console.WriteLine("-- Not enought money");
                    return false;
                }
            }
        }  
        public void Topup(string value)
        {
            
            Money = Money + Convert.ToInt32(value);
            Console.WriteLine("Your e-money: " + Money);            
        }
    }   
}

    