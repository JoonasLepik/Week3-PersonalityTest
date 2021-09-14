using System;

namespace PesonalityTestSwitch
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
            string UserColor = Console.ReadLine().ToLower();
            switch (UserColor)
            {
                case "punane":
                    Console.WriteLine("Oled romatiline");
                    break;
                case "sinine":
                    Console.WriteLine("Oled töökas.");
                    break;
                case "roheline":
                    Console.WriteLine("Oled looduse sõber!");
                    break;
                default:
                    Console.WriteLine($"Oled {UserColor} ükssarvik!");
                    break;
            }
            
            Console.WriteLine("Have a nice day!");
            Console.ReadLine();

        }
    }
}
