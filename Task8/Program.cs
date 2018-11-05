using System;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Today is: {0:D}",
                DateTime.Now);
            Console.WriteLine("The time is: {0:t}",
                DateTime.Now);
        }
    }
}
