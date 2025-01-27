using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FracturedHause
{
    public class InventorySystem
    {
        string hypen = "-----------------------------------------------------------------------------------------------------------------------";
        List<Item> items = new List<Item>();

        public void AddItem(Item newItem)
        {
            if (items.Exists(item => item.ID == newItem.ID)) // Chatgpt
            {
                Console.WriteLine($"Error: {newItem.Name} An item with the same name already exists! Could not be added.");
            }
            else
            {
                items.Add(newItem);
                Console.WriteLine($"{newItem.Name} Successfully added to inventory.");
            }
        }

        public void OpenInventory()
        {
            while (true)
            {
                Console.WriteLine("\n--- Inventory ---");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i].Name}");
                }
                Console.WriteLine("0. Exit");
                Console.WriteLine(hypen);
                Console.Write("\nSelect an option: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice)) // ChatGpt
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("Exiting inventory...");
                        break;
                    }
                    else if (choice > 0 && choice <= items.Count)
                    {
                        Console.WriteLine($"\nSelected item: {items[choice - 1].Name}");
                        Console.WriteLine(hypen);
                        Console.WriteLine($"Description: \n {items[choice - 1].Description}");
                        Console.WriteLine(hypen);
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection! Please enter a valid number.");
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a number!");
                }
            }
        }
    }

    public class Item
    {
        public string Description { get; }
        public string Name { get; }
        public int ID { get; }

        public Item(int _ID,string _Name,string _Description)
        {
            Description = _Description;
            Name = _Name;
            ID = _ID;
        }
    }
}
