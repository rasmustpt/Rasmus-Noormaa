using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            while (true)
            {
                Console.WriteLine("Sisesta siia nimi suure algustähega");
                string input = Console.ReadLine();

                names.Add(input);

                if (input == "-1")
                {
                    break;
                }
            }

            string[] name_arr = names.ToArray();

            foreach (var value in names)
            {
                Console.Write($" {value}");
            }

            Console.ReadLine();
        }
    }
}
