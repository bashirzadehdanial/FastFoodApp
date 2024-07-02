using System;
using System.Collections.Generic;

namespace FastFoodTerminal
{
   class program
   {
    static void Main(string[] args)
    {
        string[] menuItems = {"fries", "cheese", "burger", "fanta", "vegie", "burger", "kids meal"};
        List<string> orderItems = new List<string>();
        string customerName;
        bool addingMoreItems = true;

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
            orderItems.Add(menuItems[choice - 1]);
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
            Console.WriteLine($"-{item}");
           }
        }
    }
   }
}
