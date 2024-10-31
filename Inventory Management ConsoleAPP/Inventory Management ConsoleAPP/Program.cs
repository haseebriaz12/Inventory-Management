using System;

namespace Inventory_Management_ConsoleAPP
{
    class Inventory
    {
        static void Main(string[] args)
        {
            int Apple = 10;
            int Banana = 10;

            while (true)
            {
                Console.WriteLine("Inventory:");
                Console.WriteLine($"1. Apple - {Apple}");
                Console.WriteLine($"2. Banana - {Banana}");
                Console.WriteLine("Select An Item: (Press 1 for Apple) (Press 2 for Banana) (Press 0 for Exit)");

                string input = Console.ReadLine();

                if (input == "0")
                {
                    Console.WriteLine("Thank You!");
                    break;
                }

                int selectedItem;

                if (!int.TryParse(input, out selectedItem) || (selectedItem != 1 && selectedItem != 2))
                {
                    Console.WriteLine("Invalid selection. Please try again.");
                    continue;
                }


                Console.WriteLine("Enter Quantity:");
                string quantityInput = Console.ReadLine();
                int quantity;

                if (!int.TryParse(quantityInput, out quantity) || quantity <= 0)
                {
                    Console.WriteLine("Invalid quantity. Please enter a positive number.");
                    continue;
                }
                
                if (selectedItem == 1)
                {
                    if (quantity > Apple)
                    {
                        Console.WriteLine("Insufficient stock of Apple.");
                    }
                    else
                    {
                        Apple -= quantity;
                        Console.WriteLine($"{quantity} Apple(s) removed from inventory.");
                    }

                    if (Apple == 0)
                    {
                        Console.WriteLine("Apple is Out of Stock!");
                    }
                }
                else if (selectedItem == 2)
                {
                    if (quantity > Banana)
                    {
                        Console.WriteLine("Insufficient stock of Banana.");
                    }
                    else
                    {
                        Banana -= quantity;
                        Console.WriteLine($"{quantity} Banana(s) removed from inventory.");
                    }

                    if (Banana == 0)
                    {
                        Console.WriteLine("Banana is Out of Stock!");
                    }
                }
            }
        }
    }
}
