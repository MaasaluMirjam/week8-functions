using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma nimi:");
            string username = Console.ReadLine();
            Console.WriteLine("sisesta oam perekonnanimi:");
            string userlastname = Console.ReadLine();
            Console.WriteLine("Sisesta sünniaasta:");
            int userAge = Convert.ToInt32(Console.ReadLine());

            Greetings(username, userlastname, userAge);
        }

        private static void Greetings(string someString, string userlastname, int someInt)
        {
            Console.WriteLine($"Tere, {someString} {userlastname}!");           
            Console.WriteLine($"Oled {2021 - someInt}");
        }

    }
}
