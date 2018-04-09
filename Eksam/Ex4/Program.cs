using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime[] startDate = new DateTime[21];

            DateTime now = DateTime.Now;

            for (int i = 1; i <= 20; i++)
            {
                Random yyy = new Random();
                int year = yyy.Next(1940, 2010);

                Random mmm = new Random();
                int month = mmm.Next(1, 12);

                Random ddd = new Random();
                int day = ddd.Next(1, 28);

                Random hhh = new Random();
                int hour = hhh.Next(0, 24);

                Random min = new Random();
                int minute = min.Next(0, 60);

                var date = new DateTime(year, month, day, hour, minute, 00);

                Console.WriteLine(date);

                startDate[i] = date;

                System.Threading.Thread.Sleep(500);
            }

            /*VANUSTE INT ARRAY*/
            double[] vanused = new double[] {now.Year - startDate[1].Year, now.Year - startDate[2].Year, now.Year - startDate[3].Year, now.Year - startDate[4].Year,
                now.Year - startDate[5].Year, now.Year - startDate[6].Year, now.Year - startDate[7].Year, now.Year - startDate[8].Year, now.Year - startDate[9].Year,
                now.Year - startDate[10].Year,now.Year - startDate[11].Year, now.Year - startDate[12].Year, now.Year - startDate[13].Year, now.Year - startDate[14].Year,
                now.Year - startDate[15].Year, now.Year - startDate[16].Year, now.Year - startDate[17].Year, now.Year - startDate[18].Year, now.Year - startDate[19].Year,
                now.Year - startDate[20].Year};

            /*1) max vanus*/
            double maxVanus = vanused.Max();
            Console.WriteLine($"\nMaksimaalne vanus on {maxVanus} aastat");

            /*2) keskmine vanus*/
            double avg = vanused.Average();
            Console.WriteLine($"\nKeskmine vanus on {avg} aastat");

            /*3) min vanus */
            double minVanus = vanused.Min();
            Console.WriteLine($"\nMinimaalne vanus on {minVanus} aastat");
            

            /*KUUDE INT ARRAY*/
            int[] months = new int[] {startDate[1].Month, startDate[2].Month, startDate[3].Month, startDate[4].Month, startDate[5].Month, startDate[6].Month, startDate[7].Month,
                startDate[8].Month, startDate[9].Month, startDate[10].Month, startDate[11].Month, startDate[12].Month, startDate[13].Month, startDate[14].Month, startDate[15].Month,
                startDate[16].Month, startDate[17].Month, startDate[18].Month, startDate[19].Month, startDate[20].Month};
            
            /*4) millisel kuul kõige rohkem */

            var most = months.GroupBy(item => item).OrderByDescending(g => g.Count()).Select(g => g.Key).First();

            Console.WriteLine($"\nKõige rohkem on {most}. kuul!");
            
            
            /*5) kasvav järjekord */
            Array.Sort(startDate);

            Console.Write($"\n{startDate[1]}, {startDate[2]}, {startDate[3]}, {startDate[4]}, {startDate[5]}, {startDate[6]}, {startDate[7]}, {startDate[8]}, {startDate[9]}, {startDate[10]}, " +
                $"{startDate[11]}, {startDate[12]}, {startDate[13]}, {startDate[14]}, {startDate[15]}, {startDate[16]}, {startDate[17]}, {startDate[18]}, {startDate[19]}, {startDate[20]}");

            Console.ReadLine();
        }   
    }
}
