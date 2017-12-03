/*
 * kuidas pildid lisada kaardipakki
 * üks maja kaartidest ära 'peita'
 * keel ühtlustada
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

        public static void Finish(int your_summa, int my_summa)
        {
            Console.WriteLine($"\nYou have {your_summa} points");
            Console.WriteLine($"I have {my_summa} points\n");

            if (your_summa > my_summa && (your_summa < 21 && my_summa > 21))
                Console.WriteLine("You win!");

            if (your_summa < my_summa && (my_summa < 21 && your_summa > 21))
                Console.WriteLine("I win!");

            if (your_summa == my_summa && your_summa < 21 && my_summa < 21)
                Console.WriteLine("Tie!");

            if (your_summa > 21 && my_summa > 21)
                Console.WriteLine("We are both burst, so house wins!");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is blackjack game. Good luck!\n\n");

            int a = Number();
            int b = Number();

            int c = Number();
            int d = Number();

            Console.WriteLine($"Your cards are {a+Mast()} and {b+Mast()}");
            Console.WriteLine($"My cards are {c+Mast()} and {d+Mast()}\n\n");

            int your_summa = a + b;
            int my_summa = c + d;

            Console.WriteLine("What do you want to do now?\n");
            Console.WriteLine("a. draw one more card?");
            Console.WriteLine("b. finish?\n");

            string input = Console.ReadLine();

            bool väärtus = true;
            while (väärtus)
            {
                if (input == "a")
                {
                    int e = Number();
                    int f = Number();

                    Console.WriteLine($"\nYour next card is {e + Mast()}");
                    Console.WriteLine($"My next card is {f + Mast()}\n\n");

                    your_summa = your_summa + e;
                    my_summa = my_summa + f;

                    Console.WriteLine("What do you want to do now?\n");
                    Console.WriteLine("a. draw one more card?");
                    Console.WriteLine("b. finish?\n");

                    string input2 = Console.ReadLine();

                    if (input2 == "b")
                    {
                        break;

                        /*Finish(your_summa, my_summa);*/
                    }
                }
                if (input == "b")
                {
                    break;
                    
                } 
            }
            Finish(your_summa, my_summa);

            Console.ReadLine();
        }
    }
}
