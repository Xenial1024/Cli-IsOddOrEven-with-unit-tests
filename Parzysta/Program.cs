using System;

namespace IsOddOrEven
{
    class Program : Number
    {
        static void Main()
        {
            string result = Number.IsEvenOrOdd();
            Console.WriteLine("Wpisana liczba " + result);
        }
    }
}
