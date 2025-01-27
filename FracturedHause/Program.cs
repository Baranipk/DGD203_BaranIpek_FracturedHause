using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FracturedHause
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Credits = "Programming Baran İPEK\r\nInventory System helped by gpt4o\r\nNarrative Design Baranİpek";
            
                
            void ProgramLoop()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("FracturedHause");
                Console.ForegroundColor = ConsoleColor.White;
                while (true)
                {
                    Console.WriteLine("--------------------");
                    Console.WriteLine("1 Play");
                    Console.WriteLine("2 Credits");
                    Console.WriteLine("3 Close");
                    Console.WriteLine("Give inputs with numbers on the left");
                    string a =Console.ReadLine();
                    if(a == "1")
                    {
                        Game game = new Game();
                        game.StartGame();
                    }
                    else if (a == "2")
                    {
                        Console.WriteLine(Credits);
                    }
                    else if (a == "3")
                    {
                        Console.WriteLine("Exiting the game.........");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Input");
                    }
                }
            }

            ProgramLoop();
        }

    }
}
