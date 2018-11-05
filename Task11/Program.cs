using System;

namespace Task11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Вашата възраст: ");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);

            Console.WriteLine("Вашата възраст след 10 години: {0} ", age + 10);
        }
    }
}
