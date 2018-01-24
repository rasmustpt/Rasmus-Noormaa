using System;

namespace Blackjack
{
    class Program
    {
        public static string Number()
        {
            string[] numbers = { "2", "3", "4", "5", "6", "7", "8", "9", "10" };

            Random rand_number = new Random();
            string number = numbers[rand_number.Next(numbers.Length)];
            
            return number;
        }

        public static string Picture()
        {
            string[] pictures = {"J", "Q", "K", "A"};

            Random rand_pic = new Random();
            string pic = pictures[rand_pic.Next(pictures.Length)];
            
            return pic;
        }

        public static string Mast()
        {
            string[] suits = {"D", "S", "C", "H"};

            Random rand_suit = new Random();
            string suit = suits[rand_suit.Next(suits.Length)];

            return suit;
        }

        public static void Finish(int your_sum, int my_sum)
        {
            Console.WriteLine($"\nYou have {your_sum} points");
            Console.WriteLine($"I have {my_sum} points\n");

            if ((your_sum > my_sum || my_sum > 21) && your_sum <= 21)
                Console.WriteLine("You win!");

            if ((your_sum < my_sum || your_sum > 21) && my_sum <= 21)
                Console.WriteLine("I win!");

            if (your_sum == my_sum && your_sum < 21 && my_sum < 21)
                Console.WriteLine("Tie!");

            if (your_sum > 21 && my_sum > 21)
                Console.WriteLine("We are both burst, so house wins!");

            if (your_sum == 21 && my_sum == 21)
                Console.WriteLine("We both have 21 so it is a tie!");

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, this is blackjack game. Good luck!\n\n");

            string a;
            int aa;

            Random random_a = new Random();
            int suva_a = random_a.Next(0, 3);

            if (suva_a == 0 || suva_a == 1)
            {
                a = Number();
            }
            else
            {
                a = Picture();
            }

            string b;
            int bb;

            Random random_b = new Random();
            int suva_b = random_b.Next(0, 3);

            if (suva_b == 0 || suva_b == 1)
            {
                b = Number();
            }
            else
            {
                b = Picture();
            }
            
            string c;
            int cc;

            Random random_c = new Random();
            int suva_c = random_c.Next(0, 3);

            if (suva_c == 0 || suva_c == 1)
            {
                c = Number();
            }
            else
            {
                c = Picture();
            }

            string d;
            int dd;

            Random random_d = new Random();
            int suva_d = random_d.Next(0, 3);

            if (suva_d == 0 || suva_d == 1)
            {
                d = Number();
            }
            else
            {
                d = Picture();
            }
            
                Console.WriteLine($"Your cards are {a + Mast()} and {b + Mast()}");
            Console.WriteLine($"My cards are {c + Mast()} and [?]\n\n");

            if (a == "J" || a == "Q" || a == "K")
            {
                aa = 10;
            }
            else if (a == "A")
            {
                aa = 11;
            }
            else
            {
                aa = int.Parse(a);
            }

            if (b == "J" || b == "Q" || b == "K")
            {
                bb = 10;
            }
            else if (b == "A")
            {
                bb = 11;
            }
            else
            {
                bb = int.Parse(b);
            }

            if (c == "J" || c == "Q" || c == "K")
            {
                cc = 10;
            }
            else if (c == "A")
            {
                cc = 11;
            }
            else
            {
                cc = int.Parse(c);
            } 

            if (d == "J" || d == "Q" || d == "K")
            {
                dd = 10;
            }
            else if (d == "A")
            {
                dd = 11;
            }
            else
            {
                dd = int.Parse(d);
            }

            int your_sum = aa + bb;
            int my_sum = cc + dd;

            Console.WriteLine("What do you want to do now?\n");
            Console.WriteLine("a. draw one more card?");
            Console.WriteLine("b. finish?\n");

            string input = Console.ReadLine();

            bool value = true;
            while (value)
            {
                if (input == "a")
                {
                    string e;
                    int ee;

                    Random random_e = new Random();
                    int suva_e = random_e.Next(0, 3);

                    if (suva_e == 0 || suva_e == 1)
                    {
                        e = Number();
                    }
                    else
                    {
                        e = Picture();
                    }

                    string f;
                    int ff;

                    Random random_f = new Random();
                    int suva_f = random_f.Next(0, 3);

                    if (suva_f == 0 || suva_f == 1)
                    {
                        f = Number();
                    }
                    else
                    {
                        f = Picture();
                    }

                    Console.WriteLine($"\nYour next card is {e + Mast()}");
                    Console.WriteLine($"My next card is [?]\n\n");

                    if (e == "J" || e == "Q" || e == "K")
                    {
                        ee = 10;
                    }
                    else if (e == "A")
                    {
                        ee = 11;
                    }
                    else
                    {
                        ee = int.Parse(e);
                    }

                    if (f == "J" || f == "Q" || f == "K")
                    {
                        ff = 10;
                    }
                    else if (f == "A")
                    {
                        ff = 11;
                    }
                    else
                    {
                        ff = int.Parse(f);
                    }

                    your_sum = your_sum + ee;
                    my_sum = my_sum + ff;

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
