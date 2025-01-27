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
            if (items.Exists(item => item.ID == newItem.ID)) // ChatGpt Yardım Aldım
            {
                Console.WriteLine($"Hata: {newItem.Name} Adında bir item zaten mevcut! Eklenemedi.");
            }
            else
            {
                items.Add(newItem);
                Console.WriteLine($"{newItem.Name} başarıyla envantere eklendi.");
            }
        }

        public void OpenInventory()
        {
            while (true)
            {
                Console.WriteLine("\n--- ENVANTER ---");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i].Name}");
                }
                Console.WriteLine("0. Çıkış");
                Console.WriteLine(hypen);
                Console.Write("\nBir seçenek seçin: ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int choice)) // ChatGpt Yardım Aldım
                {
                    if (choice == 0)
                    {
                        Console.WriteLine("Envanterden çıkılıyor...");
                        break;
                    }
                    else if (choice > 0 && choice <= items.Count)
                    {
                        Console.WriteLine($"\nSeçilen item: {items[choice - 1].Name}");
                        Console.WriteLine($"Açıklama: \n {items[choice - 1].Description}");
                    }
                    else
                    {
                        Console.WriteLine("Geçersiz seçim! Lütfen geçerli bir numara girin.");
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen bir sayı girin!");
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
