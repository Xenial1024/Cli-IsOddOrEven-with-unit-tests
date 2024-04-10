using System;
using System.Globalization;

namespace Parzysta
{
    class Number
    {
        protected internal static float _number;
        protected internal static string _input;
        protected internal static void IsEvenOrOdd()
        {
            while (true)
            {
                Console.Write("Wpisz liczbę: ");
                _input = Console.ReadLine();
                if (!float.TryParse(_input.Replace(',', '.'), NumberStyles.Float, CultureInfo.InvariantCulture, out _number)) //zapewnienie interpretacji kropki jako separator dziesiętny i zamiana przecinka na kropkę
                {
                    Console.WriteLine("Wpisano błędną wartość lub nie wpisano jej wcale.");
                    continue;
                }
                if (_number % 1 != 0)
                    Console.WriteLine("Wpisana liczba nie jest ani parzysta ani nieparzysta.");
                if (_number % 2 == 0)
                    Console.WriteLine("Wpisana liczba jest parzysta");
                if (_number % 2 == 1)
                    Console.WriteLine("Wpisana liczba jest nieparzysta");
            }
        }
    }
}