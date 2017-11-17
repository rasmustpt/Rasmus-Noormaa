using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array__vabanduste_programm_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tegemist on vabandusi genereeriva programmiga!");
            Console.WriteLine("Sisesta komaga eraldatud vabandused: ");
            string input = Console.ReadLine();

            string[] vabandused = input.Split(',');

            Random suva = new Random();
            string vabandus = vabandused[suva.Next(vabandused.Length)];
            Console.WriteLine($"Tänase päeva vabandus on: {vabandus}" );
            
            Console.ReadLine();
        }
    }
}
