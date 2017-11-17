using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int arvuti_number = 14;
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");

            Console.Write("Sisesta siia oma pakkumine: ");
            string kasutaja_valik = Console.ReadLine();

            int kasutaja_number = int.Parse(kasutaja_valik);

            if (kasutaja_number > arvuti_number)
            {
                Console.WriteLine("Valitud number on liiga suur");
            }
            if (kasutaja_number < arvuti_number)
            {
                Console.WriteLine("Valitud number on liiga väike");
            }
            Console.ReadLine();
        }
    }
}
