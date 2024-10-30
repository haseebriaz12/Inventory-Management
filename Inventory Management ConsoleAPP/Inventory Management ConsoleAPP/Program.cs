using System;

namespace Inventory_Management_ConsoleAPP
{
    class Inventory
    {
        private int Apple;
        private int Banana;

        public Inventory(int appleQuantity, int bananaQuantity)
        {
            Apple = appleQuantity;
            Banana = bananaQuantity;
        }

        public void ManageInventory()
        {
            while (true)
            {
                Console.WriteLine("Inventory:");
                Console.WriteLine($"1. Apple - {Apple}");
                Console.WriteLine($"2. Banana - {Banana}");
                Console.WriteLine("Select An Item: (Press 1 for Apple) (Press 2 for Banana) (Press 0 for Exit)");

                string input = Console.ReadLine()?.ToLower();

                if (input == "0")
                {
                    Console.WriteLine("Thank You!");
                    break;
                }

                int selectedItem = 0;

                if (input == "1" || input == "apple")
                {
                    selectedItem = 1;
                }
                else if (input == "2" || input == "banana")
                {
                    selectedItem = 2;
                }
                else
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

        static void Main(string[] args)
        {

            Inventory inventory = new Inventory(appleQuantity: 10, bananaQuantity: 10);

            inventory.ManageInventory();
        }
    }
}
