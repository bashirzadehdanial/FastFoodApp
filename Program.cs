using System;
using System.Collections.Generic;

namespace FastFoodTerminal
{
   class program
   {
    static void Main(string[] args)
    {
        string[] menuItems = {"fries", "cheese burger", "fanta", "vegie burger", "kids meal"};

        Dictionary<string, decimal> menuItemsWithPrices = new Dictionary<string, decimal>
        {
            { "fries",  2.50M },
            { "cheese burger",   5.00M },
            { "fanta",  1.50M },
            { "vegie burger",   4.50M },
            { "kids meal",   6.00M  }
         };

        List<string> orderItems = new List<string>();
        string customerName;
        bool addingMoreItems = true;
        decimal totalOrderPrice = 0.0M;

        do
        {
            Console.WriteLine("Menu:");
            for(int i = 0; i<menuItems.Length;i++)
            {
                Console.WriteLine($"{i + 1}.{menuItems[i]}");
            }
            Console.Write("Enter the number of the item you want to order:");
            int choice;
            while(!int.TryParse(Console.ReadLine(), out choice)|| choice<1|| choice > menuItems.Length)
            {
                Console.WriteLine("Invalid input. Please enter a number from the menue.");
                Console.Write("Enter the number of the item you want to order:");
            }
            string chosenItem = menuItems[choice - 1];
            orderItems.Add(chosenItem);
            totalOrderPrice += menuItemsWithPrices[chosenItem];

            Console.Write("Add another item? (Yes/No):");
            string addMore = Console.ReadLine().Trim().ToLower();
            addingMoreItems = (addMore == "yes");

        }while(addingMoreItems);
        {
           Console.Write("Enter customer name for the order:");
           customerName = Console.ReadLine();

           Console.WriteLine($"\nOrder summery for {customerName}:");
           foreach (var item in orderItems)
           {
            Console.WriteLine($"-{item}- {menuItemsWithPrices[item]:0:00}");
           }
           Console.WriteLine($"Total:{totalOrderPrice}");

           Console.Write("\nConfirm order and proceed to payment? (yes/no): ");
           string confirmOrder = Console.ReadLine().Trim().ToLower();
           if (confirmOrder == "yes")
           {
             Console.WriteLine("\nPlease proceed with payment.");
           }
           else
            {
               Console.WriteLine("\nOrder canceled. No payment required.");
            }
            
            Console.WriteLine("\nThank you for using our fast food terminal!");
        }
    }
   }
}
