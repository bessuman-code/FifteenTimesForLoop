using System;

namespace FifteenTimesForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            ForFifteen();
        }
        public static void ForFifteen()
        {
            for (int i = 1; i < 16; i++)
            {
                Console.WriteLine($"{i} I love C#");
            }
        }
    }
}
