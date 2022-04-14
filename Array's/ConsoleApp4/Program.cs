using System;

namespace ConsoleApp4
{
    class Program
    {
        public static void Main()
        {
            int[] array = { 10, 20, 30, 40, 50, 60 };

            int som = 0;
            foreach (int item in array)
            {
                som += item;
            }
            Console.WriteLine(som);
        }
    }
}
