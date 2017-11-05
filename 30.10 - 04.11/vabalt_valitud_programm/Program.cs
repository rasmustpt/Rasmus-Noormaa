
/*
    Programmi algus on mind tutvustav. Kasutaja saab ise valida, mida ta minu kohta teada tahab(if statement, 3 valikut)
    Seejärel programm tahab, et kasutaja pakuks, mis on mu lemmikvärv, seejärel loeb alates kolmest nulli ja programmiakna
    taust läheb mu lemmikvärvi, sõltumata sellest, mida kasutaja pakub. Siis aken muutub tagasi mustaks ja kasutajat kas 
    kiidetakse või öeldakse, et ta ei pakkunud õigesti. Ja lõpetuseks tuleb täringumäng(while, random). Kasutaja valib, mitut täringut 
    ta visata tahab, arvuti viskab sama arvu ja siis liidetakse summad kokku ja see, kellel on suurem summa, võidab! P.S. Soovitan valida 
    mitte väga suure täringute arvu, kuna täringul on ka 'veeremisaeg'.
 
    Asjad, mida ise õppisin: Thread Sleep, värvi vahetamine

*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vabalt_valitud_programm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Tere, mis su nimi on?\n");
            string nimi = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Meeldiv tutvuda, " + nimi + ". Mina olen Rasmus! \n\n");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Räägin sulle natukene endast! Mida sa minu kohta teada tahaksid? Kas:\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("a) soovid teada mu vanust ja linnaosa, kus elan? (vajuta nr 1)\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("b) soovid teada kus koolis ma käin ja mida ma seal õpin? (vajuta nr 2)\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("c) soovid teada, mida mulle vabal ajal meeldib teha? (vajuta nr 3)\n");

            System.Threading.Thread.Sleep(1000);
            Console.Write("Vali nüüd: ");

            string input = Console.ReadLine();
            int huvi = int.Parse(input);

            if (huvi == 1)
            {
                Console.WriteLine("\nHetkel olen 24 aastat vana ja elan Kalamajas. Kalamaja on osake Tallinnast!\n");
            }
            if (huvi == 2)
            {
                Console.WriteLine("\nHetkel käin ma Tallinna Polütehnikumis ja õpin tarkvara-arendajaks!\n");
            }
            if (huvi == 3)
            {
                Console.WriteLine("\nVabal ajal meeldib mulle perega olla, sporti teha või raamatuid lugeda!\n");
            }

            Console.WriteLine("\n\n");
            System.Threading.Thread.Sleep(2000);
            Console.WriteLine("Paku, mis on mu lemmikvärv \n");

            string pakutu = Console.ReadLine();

            System.Threading.Thread.Sleep(500);
            Console.WriteLine("\nVaatame, kas arvasid õigesti\n");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Mu lemmikvärv on: \n");

            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("3\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("2\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("pane ennast valmis...\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("1\n");
            System.Threading.Thread.Sleep(1000);
            

            Console.BackgroundColor = ConsoleColor.Blue;
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("SININE");

            System.Threading.Thread.Sleep(3000);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;

            if (pakutu == "sinine")
            {
                Console.WriteLine("Hurraa!!! Arvasid õigesti!");
            }
            if (pakutu != "sinine")
            {
                Console.WriteLine("Panid puusse!");
            }
            System.Threading.Thread.Sleep(1000);
            
            Console.WriteLine("\nJätkame nüüd väikese mänguga\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Mul on täringud. Sina vali, mitut visata tahad.\n");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Seejärel viskan mina ka sama arvu täringuid ja vaatame, kes saab suurema " +
                "silmade arvu.\n");

            Console.Write("Kirjuta nüüd mitut täringut veeretada soovid? ");
            string arv = Console.ReadLine();
            int täringute_arv = int.Parse(arv);

            int i = 0;
            int kasutaja_summa = 0;
            
            Random r = new Random();
            while (i < täringute_arv)
            {
                
                int suvatahk = r.Next(1, 6);

                Console.Write("Täring veereb ");
                System.Threading.Thread.Sleep(300);
                Console.Write(".");
                System.Threading.Thread.Sleep(300);
                Console.Write(".");
                System.Threading.Thread.Sleep(300);
                Console.Write(". ");
                System.Threading.Thread.Sleep(300);
                Console.WriteLine(suvatahk);
               
                kasutaja_summa = kasutaja_summa + suvatahk;
                i = i + 1;
                
            }
            Console.WriteLine("Sinu täringud on visatud! Summaks tuli " + kasutaja_summa + "!\n\n\n");
            System.Threading.Thread.Sleep(1000);

            Console.WriteLine("Aga nüüd on minu kord!");

            int e = 0;
            int arvuti_summa = 0;

            Random rand = new Random();
            while (e < täringute_arv)
            {

                int suvatahk1 = rand.Next(1, 6);

                Console.Write("Täring veereb ");
                System.Threading.Thread.Sleep(300);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(".");
                System.Threading.Thread.Sleep(500);
                Console.Write(". ");
                System.Threading.Thread.Sleep(500);
                Console.WriteLine(suvatahk1);

                arvuti_summa = arvuti_summa + suvatahk1;
                e = e + 1;
            }
            Console.WriteLine("Minu summaks tuli " + arvuti_summa + ". \n");

            if (kasutaja_summa > arvuti_summa)
            {
                Console.WriteLine("Palju õnne, sina võitsid. Võid endaga rahule jääda!'\n\n");
            }
            if (kasutaja_summa < arvuti_summa)
            {
                Console.WriteLine("Kahju küll, aga seekord võitsin mina! Võib-olla sul läheb järgmisel korral paremini!\n\n");
            }

            Console.WriteLine("Sellega on tänaseks kõik! Tänan tähelepanu eest! Kõike head!");

            Console.ReadLine();
            }
    }
}
