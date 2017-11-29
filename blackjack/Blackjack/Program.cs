using System;

namespace Blackjack
{
    class Program
    {
        
        public static int Number()
        {
            int[] numbrid = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] pildid = { "S", "Q", "K", "A" };
            

            /*uuri kuidas pildid ka panna kaardipakki*/
            Random suva_number = new Random();
            int number = numbrid[suva_number.Next(numbrid.Length)];

            return number;
        }

        public static string Mast()
        {
            string[] mastid = { "D", "S", "C", "H" };

            Random suva_mast = new Random();
            string mast = mastid[suva_mast.Next(mastid.Length)];

            return mast;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is blackjack game. Good luck!");

            Console.WriteLine($"Your cards are {Number()+Mast()} and {Number()+Mast()}");
            Console.WriteLine($"My cards are {Number()+Mast()} and {Number()+Mast()}");

            Console.ReadLine();
        }
    }
}
