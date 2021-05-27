using System;
using System.Threading;
using console_war.enums;

namespace console_war
{
    class Alpha
    {
        static Random rn = new Random();
        static void Main(string[] args)
        {
            System.Console.Write("Enter the name of Player_1 : ");
            string nameOfPlayer1 = Console.ReadLine();
            System.Console.Write("Enter the name of Player_2 : ");
            string nameOfPlayer2 = Console.ReadLine();
            System.Console.WriteLine();
            System.Console.Write("BATTLE BEGINS");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            Thread.Sleep(200);
            System.Console.Write(" * ");
            
            System.Console.WriteLine();
            System.Console.WriteLine();
            Warriors goodGuy = new Warriors(nameOfPlayer1, Kind.GoodGuy);
            Warriors badGuy = new Warriors(nameOfPlayer2, Kind.BadGuy);

            while (goodGuy.isAlive && badGuy.isAlive)
            {
                if (rn.Next(0, 10) > 4) // 1 point advantage for the good guy !!
                {
                goodGuy.Attack(badGuy);    
                }
                else
                {
                badGuy.Attack(goodGuy);    
                }
                Thread.Sleep(700);

            }
        }
    }
}
