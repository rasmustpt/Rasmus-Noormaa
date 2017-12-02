/*
 * 
 * kuidas pildid lisada kaardipakki
 * kuidas talletada summasse kaart
 * üks maja kaartidest ära 'peita' (ka meetod 'proceed')
 * 'finish' meetod
 */

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

        public static void Proceed()
        {
            Console.WriteLine("What do you want to do now?\n");
            Console.WriteLine("a. draw one more card?");
            Console.WriteLine("b. finish?");

            string input = Console.ReadLine();

            if (input == "a")
            {
                Console.WriteLine($"\nYour next card is {Number() + Mast()}");
                Console.WriteLine($"My next card is {Number() + Mast()}\n\n");
                Proceed();
            }
            if (input == "b")
            {
                Finish();
            }
        }

        public static void Finish()
        {
            /*KUIDAS*/
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is blackjack game. Good luck!\n\n");

            /*kuidas talletada summa?*/

            Console.WriteLine($"Your cards are {Number()+Mast()} and {Number()+Mast()}");
            Console.WriteLine($"My cards are {Number()+Mast()} and {Number()+Mast()}\n\n");

            Proceed();

            Console.ReadLine();
        }
    }
}
