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
        Item note2 = new Item(3, "SATANİST'S BLESSİNG", "OH GREAT SATAN\r\nOH GREAT SATAN\r\nBLESSED BE US\r\nBLESSED BE US\r\nBLESS US WITH PAIN\r\nBLESS US WITH SORROW\r\nBLESS US WITH DEATH\r\nOH GREAT SATAN\r\nOH GREAT SATAN\r\nI DEDICATE MY FLESH TO YOU\r\nI DEDICATE MY HEART TO YOU\r\nI DEDICATE MY BLOOD TO YOU\r\nI DEDICATE MY LIVER TO YOU\r\nI DEDICATE MY BRAIN TO YOU\r\nI DEDICATE MYSELF TO YOU\r\nMAKE ME ONE OF YOUR DEMONS");
        Item key1 = new Item(4, "The KEY", "The KEY : The key is made of a material similar to stainless steel and shows no signs of corrosion. When you hold it, it feels 2-3 times heavier than it should be. The circle at the end appears to be crafted with extremely fine workmanship.");
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
                    Bathroom();
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
                Console.WriteLine("1 Note");
                Console.WriteLine("2 The pot");
                Console.WriteLine("3 Coal shed");
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
            Console.WriteLine("When you enter the bedroom, you are faced with a large bed surrounded by a drawn circle and a star. There are bloodstains on the bed, candles, a large vase, a key, and a painting on the mirror. In the painting, there are four young girls, one man, and a demon behind the man. The demon’s horns are long and twisted, its legs resemble those of a satyr, with a goat-like appearance. Its upper body is bear-like, covered in thick fur, and its large hands are claw-shaped, but its face resembles a human’s. The bed is completely empty, with the springs exposed, and it reeks of urine. As you look around, you find a key. On the key, it says \"Basement,\" and the end of the key is shaped like a satanic circle. You don’t find anything else in the room.");
            Console.WriteLine(hypen);
            while (true)
            {
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1 Key");
                Console.WriteLine("2 Vase");
                Console.WriteLine("3 Painting");
                Console.WriteLine("4 Inventory");
                Console.WriteLine("5 Back");
                Console.WriteLine(hypen);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    if (choice == 1)
                    {
                        inventory.AddItem(key1);
                        isBasmentUnlocked = true;
                        Console.WriteLine(hypen);
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Vase: The surface of the vase is filled with tiles and carvings, creating gaps. Inside, there is a yellow liquid resembling urine. This must be the source of the smell.");
                        Console.WriteLine(hypen);
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Painting: The painting is approximately 150 cm long and 110 cm wide. It contains four girls, one man, and a demon. The girls appear mostly happy, while the man looks very tense, and the demon is grinning.");
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
            Console.WriteLine(" Banyoya Girildi");
            Console.WriteLine(hypen);
            Console.WriteLine("You proceed to the bathroom, a broken mirror, a toilet and a bathtub meet you in the bathroom, where there should be a washbasin, there is a gap and a trace left by the old washbasin, you look around, a number of tools catch your eye on the floor, a scalpel, bandages and bone fragments from the bathtub. There is a very intense odour, when you move to the bathtub, you see a body part lying in it, a human body with no body parts above the waist welcomes you, the internal organs are completely removed, only one undercarriage, you want to leave the room in panic, but you look around with a curiosity you cannot understand, you find another note.");
            Console.WriteLine(hypen);
            while (true)
            {
                Console.WriteLine("Seçenekler");
                Console.WriteLine("1 Note");
                Console.WriteLine("2 Items on the floor");
                Console.WriteLine("3 Bathtub");
                Console.WriteLine("4 Inventory");
                Console.WriteLine("5 Back");
                Console.WriteLine(hypen);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int choice))
                {
                    if (choice == 1)
                    {
                        inventory.AddItem(note2);
                        Console.WriteLine(hypen);
                    }
                    else if (choice == 2)
                    {
                        Console.WriteLine("Items on the floor: The medical supplies on the floor seem to have been used for cutting and binding something.");
                        Console.WriteLine(hypen);
                    }
                    else if (choice == 3)
                    {
                        Console.WriteLine("Bathtub: There is no blood in the bathtub, but there are body parts, and it smells disgusting.");
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

        private void Basement()
        {

        }

        #endregion
        #endregion
    }

}
