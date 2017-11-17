using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vaba_valik
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\n\n**********Laomajanduse programm**********\n\n\n\n");

            Console.WriteLine("Kas oled admin ja soovid sisse logida(1) või soovid kasutaja luua(2)?"); /*Kas logida sisse kui admin või teha´uus kasutaja*/
            string input1 = Console.ReadLine();
            int valik1 = int.Parse(input1);

            if (valik1 == 1) /*Kui logida sisse adminnina*/
            {
                
                Console.WriteLine("Tere admin! Rõõm sind jälle näha siin\n");

                Menu:  /*See on peamenüü*/
                System.Threading.Thread.Sleep(700);
                Console.Clear();
                
                Console.WriteLine("Mida soovid teha? Kas...\n");

                Console.WriteLine("a) lisada uut töötajat? (vajuta nr 1)\n");
                Console.WriteLine("b) vaadata töötajate nimekirja? (vajuta nr 2)\n");
                Console.WriteLine("c) vaadata laoseisusid? (vajuta nr 3)\n");
                Console.WriteLine("d) teha ostutellimust? (vajuta nr 4)\n");
                Console.WriteLine("e) välja logida? (vajuta nr 5)\n");

                string input2 = Console.ReadLine();
                int valik2 = int.Parse(input2);

                if (valik2 == 1) /*selle inimese peaks ka lisama järgmisele punktile*/
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n*********Uue töötaja lisamine*********\n\n\n\n\n");

                    Console.Write("Sisesta siia nimi:   \n");
                    string tootaja_nimi = Console.ReadLine();

                    Console.Write("Sisesta siia ametikoht:   \n");
                    string amet = Console.ReadLine();
                    
                    Console.WriteLine("Lisasid: " + tootaja_nimi + " - " + amet + "\n");
                    Console.WriteLine("NB! Töötaja lisamisel on aksepteerimisaeg, st uut töötajat ei näidata kohe töötajate nimekirjas.");


                    Console.WriteLine("\n\n\nMida soovid edasi teha? Kas menüüsse minna (1) või välja logida (2)?\n");
                    string val_1 = Console.ReadLine();
                    int val1 = int.Parse(val_1);

                    if (val1 == 1)
                    {
                        goto Menu;
                    }
                    if (val1 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Täname, et kasutasid meie programmi. Nägemist!");

                        int i = 3;

                        while (i > 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine(i + "\n");
                            i -= 1;
                        }
                    }
                }
                if (valik2 == 2) /*kui valida teine valik admin kasutajast*/
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n*********Sinu töötajad*********\n\n\n");

                    Console.WriteLine("Siim Piim - ostujuht\n");
                    Console.WriteLine("Larissa Semjonova - personalijuht\n");
                    Console.WriteLine("Gunnar Mägi - lao-juhataja\n");
                    Console.WriteLine("Rainer Sook - lao-operaator\n");
                    Console.WriteLine("Tiina Tolm - lao-operaator\n");

                    Console.WriteLine("\n\n\nMida soovid edasi teha? Kas menüüsse minna (1) või välja logida (2)?\n");
                    string val_1 = Console.ReadLine();
                    int val1 = int.Parse(val_1);

                    if (val1 == 1)
                    {
                        goto Menu;
                    }
                    if (val1 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Täname, et kasutasid meie programmi. Nägemist!");
                    }
                    int i = 3;

                    while (i > 0)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(i + "\n");
                        i -= 1;
                    }
                }
                if (valik2 == 3) /*kui valida kolmas valik admin kasutajast*/
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n*********Sinu laojäägid********* \n\n\n");

                    Console.WriteLine("Kruvid 38x80 - 6800tk\n");
                    Console.WriteLine("Kruvid 50x90 - 2200tk\n");
                    Console.WriteLine("Naelad 20x50 - 13 340\n");
                    Console.WriteLine("Prussid 28x55x5400 - 135tk\n");
                    Console.WriteLine("Prussid 40x110x4600 - 37tk\n");
                    Console.WriteLine("Fassaadilauad - 361tk\n");
                    Console.WriteLine("Aknad - 13tk\n");
                    Console.WriteLine("Välisuksed - 11tk\n");
                    Console.WriteLine("Siseuksed - 27tk\n");

                    Console.WriteLine("\n\n\nMida soovid edasi teha? Kas menüüsse minna (1) või välja logida (2)?\n");
                    string val_3 = Console.ReadLine();
                    int val3 = int.Parse(val_3);

                    if (val3 == 1)
                    {
                        goto Menu;
                    }
                    if (val3 == 2)
                    {
                        Console.Clear();
                        Console.WriteLine("Täname, et kasutasid meie programmi. Nägemist!");
                        int i = 3;

                        while (i > 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine(i + "\n");
                            i -= 1;
                        }
                    }
                }
                if (valik2 == 4) /*kui valida neljas valik admin kasutajast*/
                {
                    Console.Clear();
                    Console.WriteLine("Tee uus ostutellimus\n\n\n");

                    Console.WriteLine("Vali, mis tooteid tellida tahad: (korraga saab tellida ainult ühte asja)\n");

                    Console.WriteLine("Kruvid 38x80 (vajuta nr 1)\n");
                    Console.WriteLine("Kruvid 50x90 (vajuta nr 2)\n");
                    Console.WriteLine("Naelad 20x50 (vajuta nr 3)\n");
                    Console.WriteLine("Prussid 28x55x5400 (vajuta nr 4)\n");
                    Console.WriteLine("Prussid 40x110x4600 (vajuta nr 5)\n");
                    Console.WriteLine("Fassaadilauad (vajuta nr 6)\n");
                    Console.WriteLine("Aknad (vajuta nr 7)\n");
                    Console.WriteLine("Välisuksed (vajuta nr 8)\n");
                    Console.WriteLine("Siseuksed (vajuta nr 9)\n\n");

                    string ost_1 = Console.ReadLine();
                    int ost1 = int.Parse(ost_1);
                    /*
                    Console.WriteLine("Kas soovid veel midagi tellida? (jah/ei)\n");
                    string veel2 = Console.ReadLine();
                    if (veel2 == "jah\n")
                    {
                        Console.Write("Vali siis number: \n");
                        string ost_2 = Console.ReadLine();
                        int ost2 = int.Parse(ost_2);

                        Console.Write("Kas soovid veel midagi tellida? (jah/ei)\n"); 
                        string veel3 = Console.ReadLine();
                        if (veel3 == "jah\n")
                        {
                            Console.WriteLine("Kirjuta number: \n");
                            string ost_3 = Console.ReadLine();
                            int ost3 = int.Parse(ost_3);
                            Console.WriteLine("Tellisid " + ost1 + ", " + ost2 + " ja " + ost3 + "Ühe tellimusega saabki tellida maksimaalselt 3 toodet. " +
                                "Kaup saabub 2 päeva jooksul!\n");
                        }
                        if (veel3 == "ei\n")
                        {
                            Console.WriteLine("Tellisid " + ost1 + " ja " + ost2 + ". Tellimus jõuab sinuni 2 päeva jooksul!\n");
                        }
                    }
                    if (veel2 == "ei\n")
                    {*/
                        Console.WriteLine("\nTellisid toodet number " + ost1 + ". Kaup saabub 2 päeva jooksul!\n");
                    
                }
                Console.WriteLine("\n\n\nMida soovid edasi teha? Kas menüüsse minna (1) või välja logida (2)?\n");
                string val_4 = Console.ReadLine();
                int val4 = int.Parse(val_4);

                if (val4 == 1)
                {
                    goto Menu;
                }
                if (val4 == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Täname, et kasutasid meie programmi. Nägemist!");

                    int i = 3;

                    while (i > 0)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(i + "\n");
                        i -= 1;
                    }
                }

                if (valik2 == 5) /*kui valida 5 valik admin kasutajast*/
                {
                    Console.Clear();
                    Console.WriteLine("Logisid välja. Täname, et kasutasid meie programmi!");

                    int i = 3;

                    while (i > 0)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(i + "\n");
                        i -= 1;
                    }
                }
            }


            if (valik1 == 2) /*kui teha uus kasutaja*/
            {
                Console.Clear();
                Console.WriteLine("\n\n\n*********Tere tulemast kasutama laomajanduse programmi. Tee endale kasutaja!*********\n\n\n");

                Console.Write("Sisesta siia oma nimi. Sellest saab sinu kasutajanimi:   ");
                string nimi = Console.ReadLine();
                Console.Write("Sisesta siia parool: ");
                string parool1 = Console.ReadLine();
                Console.Write("Sisesta parool uuesti:   ");
                string parool2 = Console.ReadLine();

                if (parool1 == parool2)
                {
                    Console.WriteLine("Sobib! Kasutaja tehtud."); /*kui kasutaja tegemine õnnestub*/
                    
                    Menu2: /*see on tavakasutaja menüü*/

                    Console.Clear();
                    Console.WriteLine("Mida soovid teha? Kas: \n"); 

                    Console.WriteLine("Vaadata töötajate nimekirja (vajuta nr 1)\n");
                    Console.WriteLine("Vaadata laojääke (vajuta nr 2)\n");
                    Console.WriteLine("Vaadata/välja printida komplekteerimisliste (vajuta nr 3)\n");
                    Console.WriteLine("Välja logida (vajuta nr 4)\n");

                    string uus_valik_ = Console.ReadLine();
                    int uus_valik = int.Parse(uus_valik_);

                    if (uus_valik == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\n*********Töötajate nimekiri*********\n\n\n"); /*kui valida tavakasutaja menüüst 1. valik*/

                        Console.WriteLine("Siim Piim - ostujuht\n");
                        Console.WriteLine("Larissa Semjonova - personalijuht\n");
                        Console.WriteLine("Gunnar Mägi - lao-juhataja\n");
                        Console.WriteLine("Rainer Sook - lao-operaator\n");
                        Console.WriteLine("Tiina Tolm - lao-operaator\n");

                        Console.WriteLine("\n\n\nMida soovid edasi teha? Kas menüüsse minna (1) või välja logida (2)?\n");
                        string val_1 = Console.ReadLine();
                        int val1 = int.Parse(val_1);

                        if (val1 == 1)
                        {
                            goto Menu2;
                        }
                        if (val1 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Täname, et kasutasid meie programmi. Nägemist!");
                        }
                        int i = 3;

                        while (i > 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine(i + "\n");
                            i -= 1;
                        }
                    }
                    if (uus_valik == 2) /*kui valida tavakasutaja menüüst 2. valik*/
                    {
                        Console.Clear();

                        Console.WriteLine("\n\n\n*********Laojäägid********* \n\n\n");

                        Console.WriteLine("Kruvid 38x80 - 6800tk\n");
                        Console.WriteLine("Kruvid 50x90 - 2200tk\n");
                        Console.WriteLine("Naelad 20x50 - 13 340\n");
                        Console.WriteLine("Prussid 28x55x5400 - 135tk\n");
                        Console.WriteLine("Prussid 40x110x4600 - 37tk\n");
                        Console.WriteLine("Fassaadilauad - 361tk\n");
                        Console.WriteLine("Aknad - 13tk\n");
                        Console.WriteLine("Välisuksed - 11tk\n");
                        Console.WriteLine("Siseuksed - 27tk\n");

                        Console.WriteLine("\n\n\nMida soovid edasi teha? Kas menüüsse minna (1) või välja logida (2)?\n");
                        string val_3 = Console.ReadLine();
                        int val3 = int.Parse(val_3);

                        if (val3 == 1)
                        {
                            goto Menu2;
                        }
                        if (val3 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Täname, et kasutasid meie programmi. Nägemist!");
                        }
                        int i = 3;

                        while (i > 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine(i + "\n");
                            i -= 1;
                        }
                    }
                    if (uus_valik == 3) /*kui valida tavakasutaja menüüst 3. valik*/
                    {
                        Console.Clear();
                        Console.WriteLine("\n\n\nHetkel ei ole komplekteerimist ootavaid nimekirju!\n\n\n");

                        Console.WriteLine("\n\n\nMida soovid edasi teha? Kas menüüsse minna (1) või välja logida (2)?\n");
                        string val_3 = Console.ReadLine();
                        int val3 = int.Parse(val_3);

                        if (val3 == 1)
                        {
                            goto Menu2;
                        }
                        if (val3 == 2)
                        {
                            Console.Clear();
                            Console.WriteLine("Täname, et kasutasid meie programmi. Nägemist!");
                        }
                        int i = 3;

                        while (i > 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine(i + "\n");
                            i -= 1;
                        }

                    }
                    if (valik1 == 4) /*kui valida tavakasutaja menüüst 4. valik*/
                    {
                        Console.WriteLine("Logisid välja. Täname, et kasutasid meie programmi!");

                        int i = 3;

                        while (i > 0)
                        {
                            System.Threading.Thread.Sleep(1000);
                            Console.WriteLine(i + "\n");
                            i -= 1;
                        }
                    } 
                }

                if (parool1 != parool2)
                {
                    Console.WriteLine("Parool peab mõlemal sisestusel identne olema!\n\n\n");
                    Console.WriteLine("Programm sulgub!\n");

                int i = 3;
                    
                while (i > 0)
                    {
                        System.Threading.Thread.Sleep(1000);
                        Console.WriteLine(i + "\n");
                        i -= 1;
                    }
                }
            }
        }
    }
}
