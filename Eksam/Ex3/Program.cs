using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta siia minimaalne aastaarv");
            string a = Console.ReadLine();
            int min = int.Parse(a);

            Console.WriteLine("Sisesta siia maksimaalne aastaarv");
            string b = Console.ReadLine();
            int max = int.Parse(b);

            Console.WriteLine("Sisesta siia genereeritavate andmete hulk");
            string c = Console.ReadLine();
            int quantity = int.Parse(c);

            int d = 0;

            while (d < quantity)
            {
                Random yyy = new Random();
                int year = yyy.Next(min, max);

                Random mmm = new Random();
                int month = mmm.Next(1, 12);

                Random ddd = new Random();
                int day = ddd.Next(1, 28);

                Random hhh = new Random();
                int hour = hhh.Next(0, 24);

                Random minutes = new Random();
                int minute = minutes.Next(0, 60);

                var date = new DateTime(year, month, day, hour, minute, 00);

                Console.WriteLine(date);

                d = d + 1;

                System.Threading.Thread.Sleep(500);


            }

            Console.ReadLine();
        }
    }
}
