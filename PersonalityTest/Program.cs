using System;

namespace PersonalityTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Progamm küsib kasutajat sisestada tema lemmikvärvi;
            //Kui kasutaja sisestab ""punane", konsool kuvab "oled romantiline";
            //Kui Kasutaja sisentab ""sinine", konsool kuvab "oled töökas";
            //Kui Kasutaja sisentab ""roheline", konsool kuvab "oled loduse sõber";
            //Kui Kasutaja sisentab midagi muud, konsool kuvab "oled ükssarvik";
            Console.WriteLine("What's your favorite color?:");
            string UserColor = Console.ReadLine();
            if (UserColor == "punane")
            {
                Console.WriteLine("Oled romatiline inimene!");

            }
            else if (UserColor == "sinine")
            {
                Console.WriteLine("Oled töökas inimene.");

            }
            else if (UserColor == "roheline")
            {
                Console.WriteLine("Oled looduse sõber!");
            }
            else
            {
                Console.WriteLine($"Oled {UserColor} ükssarvik!");
            }
            Console.ReadLine();
        }
    }
}
