/*
 * kuidas pildid lisada kaardipakki
 */

using System;

namespace Blackjack
{
    class Program
    {
        public static int Number()
        {
            int[] numbers = { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            string[] pictures = { "S", "Q", "K", "A" };
            
            /*uuri kuidas pildid ka panna kaardipakki*/
            Random rand_number = new Random();
            int number = numbers[rand_number.Next(numbers.Length)];

            return number;
        }

        public static string Mast()
        {
            string[] suits = { "D", "S", "C", "H" };

            Random rand_suit = new Random();
            string suit = suits[rand_suit.Next(suits.Length)];

            return suit;
        }

        public static void Finish(int your_sum, int my_sum)
        {
            Console.WriteLine($"\nYou have {your_sum} points");
            Console.WriteLine($"I have {my_sum} points\n");

            if ((your_sum > my_sum || my_sum > 21) && your_sum < 21)
                Console.WriteLine("You win!");

            if ((your_sum < my_sum || your_sum > 21) && my_sum < 21)
                Console.WriteLine("I win!");

            if (your_sum == my_sum && your_sum < 21 && my_sum < 21)
                Console.WriteLine("Tie!");

            if (your_sum > 21 && my_sum > 21)
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
            Console.WriteLine($"My cards are {c+Mast()} and [?]\n\n");

            int your_sum = a + b;
            int my_sum = c + d;

            Console.WriteLine("What do you want to do now?\n");
            Console.WriteLine("a. draw one more card?");
            Console.WriteLine("b. finish?\n");

            string input = Console.ReadLine();

            bool value = true;
            while (value)
            {
                if (input == "a")
                {
                    int e = Number();
                    int f = Number();

                    Console.WriteLine($"\nYour next card is {e + Mast()}");
                    Console.WriteLine($"My next card is [?]\n\n");

                    your_sum = your_sum + e;
                    my_sum = my_sum + f;

                    Console.WriteLine("What do you want to do now?\n");
                    Console.WriteLine("a. draw one more card?");
                    Console.WriteLine("b. finish?\n");

                    string input2 = Console.ReadLine();

                    if (input2 == "b")
                    {
                        break;

                        Finish(your_sum, my_sum);
                    }
                }
                if (input == "b")
                {
                    break;
                    
                }
            }
            Finish(your_sum, my_sum);
            Console.ReadLine();
        }
    }
}
