using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int arvuti_nr = r.Next(1, 100);
            int valik = 0;

            bool tõene = false;

            Console.WriteLine("Ma valin suvaliselt ühe numbri (1 - 100). Katsu see ära arvata!");

            while (!tõene)
            {
                Console.Write("Paku: ");
                string kasutaja_nr = Console.ReadLine();

                if (!int.TryParse(kasutaja_nr, out valik))
                {
                    Console.WriteLine("See ei ole number!");
                    continue;
                }

                if (valik < arvuti_nr)
                {
                    Console.WriteLine("Minu valitud number on suurem!");
                }
                else if (valik > arvuti_nr)
                {
                    Console.WriteLine("Minu valitud number on väiksem!");
                }
                else
                {
                    tõene = true;
                    Console.WriteLine("Tubli! Arvasid ära!");
                }
            }
            Console.ReadLine();
        }
    }
}
