using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FracturedHause
{
    public class Game
    {
        InventorySystem inventory = new InventorySystem();
        public string userName;
        bool isBasmentUnlocked = false;

        #region Items
        Item note1 = new Item(0,"Note of sun","Sun is Very Very Big");
        #endregion

        public void StartGame()
        {
            userName = GetUserName();            
            Console.WriteLine("Oyun Giriş Yazısı");

            RoomSelection();
        }


        #region GetName
        static string GetUserName()
        {
            Console.Write("Lütfen isminizi girin: ");
            string name = Console.ReadLine();
          
            while (string.IsNullOrWhiteSpace(name))
            {
                Console.Write("İsim boş olamaz, lütfen geçerli bir isim girin: ");
                name = Console.ReadLine();
            }

            return name;
        }
        #endregion

        #region RoomSelection
        private void RoomSelection()
        {
            while (true)
            {
                Console.WriteLine("Hol Yazısı");
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1.mutfak");
                Console.WriteLine("2.salon");
                Console.WriteLine("3.banyo");
                if (isBasmentUnlocked)
                {
                    Console.WriteLine("4.bodrum");
                }
                else
                {
                    Console.WriteLine("4.bodrum (isLocked)");
                }
                Console.WriteLine("5.Inventory");
                Console.WriteLine("6.oyundançık");
                string input = Console.ReadLine();

                if(input.ToLower().Trim() == "1")
                {
                    Kitchen();
                }
                else if (input.ToLower().Trim() == "2")
                {
                    Console.WriteLine("Salon");
                }
                else if (input.ToLower().Trim() == "3")
                {
                    Console.WriteLine();
                }
                else if (input.ToLower().Trim() == "4")
                {
                    if (isBasmentUnlocked)
                    {
                        Console.WriteLine("bodrum");
                    }
                    else
                    {
                        Console.WriteLine("Bodrum (Kilitli)");
                    }
                }
                else if (input.ToLower().Trim() == "5")
                {
                    Console.WriteLine("Inventory");
                }
                else if (input.ToLower().Trim() == "6")
                {
                    Console.WriteLine("Evden Çıktınız Oyun Bitti");
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlış Giriş Yaptınız");
                }
            }
        }

        #region Rooms

        private void Kitchen()
        {
            
            Console.WriteLine(" Mutfağa Grildi");
            while (true)
            {
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1 Not");
                Console.WriteLine("2 Dolap");
                Console.WriteLine("3 Evye");
                Console.WriteLine("4 Inventory");
                Console.WriteLine("5 höle Geri Dön");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    if(choice == 1)
                    {
                        inventory.AddItem(note1);
                    }
                    else if(choice == 2) 
                    {
                        Console.WriteLine("Dolap");
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Evye");
                    }
                    else if (choice == 4)
                    {
                        inventory.OpenInventory();
                    }
                    else if (choice == 5)
                    {
                        Console.WriteLine("Hole Geri Dönülüyor...");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Lütfen bir sayı girin!");
                }
            }
        }

        private void Bedroom()
        {

        }

        private void Bathroom()
        {

        }

        private void Basement()
        {

        }

        #endregion
        #endregion
    }

}
