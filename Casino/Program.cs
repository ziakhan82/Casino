using System;
using System.Threading;
using SomeGuys;

namespace Casino
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            double odd = 0.75;

            Guy Player = new Guy() {Name = "Palyer", Cash = 100};
            Console.WriteLine("Welcome to Reskilde Casino Bad Boys The Odds Are " +odd );

            while (Player.Cash>0)
            {
                Player.WriteMyInfo();
                Console.WriteLine("How much do you wan to bet");
                string HowMuch = Console.ReadLine();

                if (int.TryParse(HowMuch, out int amount ))
                {
                    int pot = Player.GiveCash(amount) * 2;
                    if (pot > 0)
                    {
                        if (random.NextDouble() > odd)
                        {

                            int winnings = pot;
                            Console.WriteLine("You Win " + winnings);
                            Player.ReceiveCash(winnings);

                        }
                    }
                    else
                    {
                        Console.WriteLine("back Luck you lose");
                    }

                }
                else
                {
                    Console.WriteLine("Enter a valid Number ");
                }
                }

            Console.WriteLine("the house alwyas wins");
        }


        }
    
}
