using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tunnikontroll
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Taco Palenque");
            Console.WriteLine("1200 Main ST.");
            Console.WriteLine("-------------");

            double valik = 0;
            bool tõene = true;
            double summa = 0;

            Console.Write("Enter price of food item [-1 to quit]: ");

            while (tõene)
            {

                Console.WriteLine("Enter price of food item [-1 to quit]: ");
                string input = Console.ReadLine();
                double input_ = int.Parse(input);

                if (!double.TryParse(input, out valik))
                {
                    Console.WriteLine("This is not price!");
                    continue;
                }
                if (valik == -1)
                {
                    break;
                }
                if (true)
                {
                    summa = summa + valik;
                    continue;
                }
            }

            Console.+-
            Console.WriteLine($"Subtotal: €{summa}");
            Console.WriteLine($"15% Gratuity: €{summa*0.15}");
            Console.WriteLine($"Total: €{summa-(summa*0.15)}");

            Console.WriteLine("Press any key to continue: ");
            Console.ReadLine();
        }
    }
}
