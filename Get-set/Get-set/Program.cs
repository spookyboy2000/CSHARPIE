using System;

namespace Get_set
{
    internal class Program
        {
        static void Main(string[] args)
        {
            PAW bark = DOG.GetPAW();
            Console.WriteLine(bark.name);
            DOG.SetPAW(new PAW("voed"));
            bark = DOG.GetPAW();
            Console.WriteLine(bark.name);
        }
    }
}
