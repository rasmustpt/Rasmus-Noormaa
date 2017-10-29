using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ma valin välja ühe suvalise numbri vahemikus [1 – 100]. Proovi see ära arvata");
            int arvuti_number = 12;

            Console.Write("Tee oma pakkumine:");
            string kasutaja_valik = Console.ReadLine();

            int kasutaja_number = int.Parse(kasutaja_valik);

            if (kasutaja_number > arvuti_number)
            {
                Console.WriteLine("Valisid liiga suure numbri!");
            }
            if (kasutaja_number < arvuti_number)
            {
                Console.WriteLine("Valisid liiga väikese numbri!");
            }
            if (kasutaja_number == arvuti_number)
            {
                Console.WriteLine("Arvasid numbri ära!");
            }
            Console.ReadLine();

        }
    }
}
