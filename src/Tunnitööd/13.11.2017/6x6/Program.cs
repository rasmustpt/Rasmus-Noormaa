using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6x6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*********Korrutustabel*********\n\n\n");

            for (int x = 1; x <= 6; x++)
            {
                for (int y = 1; y <= 6; y++)
                {
                    Console.Write(x * y + "\t");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
