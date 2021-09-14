using System;

namespace GradingIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis hinde sa said?");
            int Grade = Convert.ToInt32(Console.ReadLine());
            if (Grade == 5)
            {
                Console.WriteLine("Suurepärane");
            }
            else if (Grade == 4)
            {
             Console.WriteLine("Väga hea");
            }
            else if (Grade == 3)
            {
             Console.WriteLine("Hea");
            }
            else if (Grade == 2)
            {
                Console.WriteLine("Rahuldav");
            }
            else if (Grade == 1)
            {
                Console.WriteLine("Puudulik");
            }
            else
            {
                Console.WriteLine("Puudulik");
            }
            Console.WriteLine("Have A nice day!");
            Console.ReadLine();
        }
    }
}
