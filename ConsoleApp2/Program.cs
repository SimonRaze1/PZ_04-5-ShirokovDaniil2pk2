using System;

namespace PZ_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i = 0, j = 30; i + j != 8; i++, j--)
            {
                Console.WriteLine("i:" + i + ", j:" + j);
            }
        }
    }
}
