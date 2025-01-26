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
            string Credits = "Credits";
            string BaşlangıçYazısı = "Başlangıç Yazısı";
                
            void ProgramLoop()
            {

                while (true)
                {
                    Console.WriteLine(BaşlangıçYazısı);
                    Console.WriteLine("seçenekler :");
                    Console.WriteLine("1 oyunubaşlat");
                    Console.WriteLine("2 credits");
                    Console.WriteLine("3 oyunukapat");
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
                        Console.WriteLine("Oyundan çıkılıyor....");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Yanlış Girdiniz");
                    }
                }
            }

            ProgramLoop();
        }

    }
}
