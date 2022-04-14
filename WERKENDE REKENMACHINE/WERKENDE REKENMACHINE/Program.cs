using System;

namespace WERKENDE_REKENMACHINE
{
    internal class rekenmachine
    {
        internal int optellen(int getal1, int getal2)
        {
            return getal1 + getal2;
        }
        internal int aftrekken(int getal1, int getal2)
        {
            return getal1 - getal2;
        }
        internal int vermedigvuldiggen(int getal1, int getal2)
        {
            return getal1 / getal2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            rekenmachine Rekenmachine = new rekenmachine();
            Console.WriteLine(Rekenmachine.optellen(2, 5));
            Console.WriteLine(Rekenmachine.aftrekken(2, 5));
            Console.WriteLine(Rekenmachine.vermedigvuldiggen(2, 5));
        }
    }
}
