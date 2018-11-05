using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 2; i<103 ; i++)
            {
                if (i % 2 == 0) Console.Write(i);
                else Console.Write(",-{0},", i);
            }
        }
    }
}
