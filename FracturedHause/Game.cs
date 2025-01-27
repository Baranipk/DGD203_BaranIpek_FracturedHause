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
        string hypen = "-----------------------------------------------------------------------------------------------------------------------";
        #region Items
        Item note0 = new Item(1, "Note - UNKOWN", "GET OUT OF THIS HOUSE\r\nTHIS HOUSE IS CURSED\r\nGET OUT OF THIS HOUSE\r\nTHIS HOUSE IS CURSED\r\nGET OUT OF THIS HOUSE\r\nTHIS HOUSE IS CURSED\r\nGET OUT OF THIS HOUSE\r\nTHIS HOUSE IS CURSED\r\nTHIS HOUSE IS A CURSE\r\nCURSE\r\nTHIS HOUSE\r\nHOUSE\r\nDEATH.");
        Item note1 = new Item(2, "Note - For BAPHOMET", "3 deer hearts\r\n4 human scalps\r\n2 rabbit feet\r\nBoil slowly.\r\n4 liters of cow's blood\r\n3 human molars\r\n2 Datura stramonium\r\n1 oak tree root\r\n3 liters of water\r\nCow intestines\r\nRabbit liver\r\nRabbit ear");
        
        #endregion

        public void StartGame()
        {
            userName = GetUserName();
            Console.WriteLine(hypen);
            //start text
            Console.WriteLine("One day, we receive a letter from our grandfather. The letter mentions that there is a family-owned mountain house, and we are asked to visit it to check the tools and equipment inside and assess the condition of the house. We set off immediately. When we arrive at the house, we notice that the trees around it are dead, and their branches are dried up. We also see that the exterior of the house is completely moldy and decayed. We try to open the door, but the wooden door creaks and is difficult to open. Despite trying the keys, we are unable to enter. We spend some time in front of the door and begin to explore the house. The house is two stories, including the roof. Outside, we see broken garden decorations, a path leading into the forest, and a few animal carcasses lying on the ground. We head back to the door, attempting once again to get inside.");
            Console.WriteLine(hypen);
            Console.WriteLine("When we first enter the house, we are greeted by a spacious hallway and living room. The other rooms are accessible from here. Inside, four doors catch our attention: the bathroom, kitchen, bedroom, and basement. We head towards the basement door and try to open it, but it is locked. Afterward, we take a good look around the house. On the walls, there are photographs of family members, an old sofa set, chandeliers, candelabras, and the corpses of rodents that have infiltrated the house, along with their droppings. Some of the rodents have bite-like marks on them. Unable to make sense of this, we assume it must have been the work of the other rodents. As we explore further, we come across a glass of water on a table, along with some old containers that resemble medicine boxes. As we move closer to examine them, a sticky, feces-like substance clings to our foot. We continue and look at the glass of water; inside, there are artificial dentures and some dried blood stains. Suddenly, the back door creaks and closes on its own, the sound of the wind echoing throughout the house. Although our heart rate quickens, we remain calm and reach for the paper next to the glass.");
            Console.WriteLine(hypen);
            inventory.AddItem(note0);
            Console.WriteLine(hypen);
            RoomSelection();
        }


        #region GetName
        static string GetUserName()
        {
            Console.Write("Lütfen isminizi girin: ");
            string name = Console.ReadLine();
          
            while (string.IsNullOrWhiteSpace(name)) // chat gpt
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
                Console.WriteLine("Hole Girildi");
                Console.WriteLine(hypen);
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1.mutfak");
                Console.WriteLine("2.Bedroom");
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
                Console.WriteLine(hypen);
                string input = Console.ReadLine();

                if(input.ToLower().Trim() == "1")
                {
                    Kitchen();
                }
                else if (input.ToLower().Trim() == "2")
                {
                    Bedroom();
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
                        Console.WriteLine(hypen);
                    }
                }
                else if (input.ToLower().Trim() == "5")
                {
                    inventory.OpenInventory();
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
            Console.WriteLine("When you enter the kitchen, you are faced with a long island counter and a stove. On the stove, there is a large pot, and there are chairs with peeling upholstery and a table split in half. You begin to look around to understand what has happened inside. The window looks out to the back side of the house. The first thing you notice in the kitchen are the burned animal parts in the coal shed. It’s as if someone burned animals to make charcoal, cutting off their oxygen supply and storing them there. You then move towards the counter, where you find a note and a vase. The vase has scratched surfaces, and its carvings have fallen off. You move towards the stove, where there is a large pot. The inside of the pot is covered with a slimy and sticky substance, as if something has been pressed onto it. You take a piece of wood and check inside the pot, finding what seems to be organs, body parts of animals, and human teeth. Your stomach churns, and you feel as if you might vomit. You turn towards the window, where you see something resembling a silhouette in the distance, but it disappears quickly. You tense up, your heart rate increases, and you continue looking around. The floorboards creak, but there’s nothing else in the kitchen.");
            Console.WriteLine(" Mutfağa Grildi");
            Console.WriteLine(hypen);
            while (true)
            {
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1 Not");
                Console.WriteLine("2 KAZAN");
                Console.WriteLine("3 KÖMÜRLÜK");
                Console.WriteLine("4 Inventory");
                Console.WriteLine("5 höle Geri Dön");
                Console.WriteLine(hypen);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    if(choice == 1)
                    {
                        inventory.AddItem(note1);
                        Console.WriteLine(hypen);
                    }
                    else if(choice == 2) 
                    {
                        Console.WriteLine("The pot: Inside an old pot, there is a strange, muddy liquid, and everything is stained. When you stir it, you find pieces of animals and human teeth inside.");
                        Console.WriteLine(hypen);
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Coal shed: Inside the coal shed, there are burned animal bodies and charcoal. The charcoal looks like it has been there for a long time and is covered in moss.");
                        Console.WriteLine(hypen);
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
            Console.WriteLine(" yatak odası Grildi");
            Console.WriteLine(hypen);
            Console.WriteLine("Bedrumyazısı");
            Console.WriteLine(hypen);
            while (true)
            {
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1 item");
                Console.WriteLine("2 eşya1");
                Console.WriteLine("3 eşya2");
                Console.WriteLine("4 Inventory");
                Console.WriteLine("5 Back");
                Console.WriteLine(hypen);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    if (choice == 1)
                    {
                        inventory.AddItem(null);
                        Console.WriteLine(hypen);
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(hypen);
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(hypen);
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
