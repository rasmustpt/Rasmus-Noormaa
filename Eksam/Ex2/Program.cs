using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta siia laused, kus on sees nimed:");

            string[] names = new string[10] {"kaur","mattias","kristel","heleri","trevor",
            "kristjan","kelli","kevin","maarika","laura" };
            {
                int index = 0;
                while (index < names.Length)
                {
                    string name = names[index];

                    string capital = char.ToUpper(name[0]) + name.Substring(1).ToLower();

                    Console.Write(capital);

                    index += 1;

                    if (index < names.Length)
                    {
                    Console.Write(",");
                    }   
                }
            }
            Console.ReadLine();
        }
    }
}