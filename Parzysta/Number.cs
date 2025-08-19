using System;
using System.Globalization;

namespace IsOddOrEven
{
    public class Number
    {
        private protected static float _number;
        private protected static string _input;
        public static string IsEvenOrOdd()
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
                    return "nie jest ani parzysta ani nieparzysta";
                else if (_number % 2 == 0)
                    return "jest parzysta";
                else if (_number % 2 == 1)
                    return "jest nieparzysta";
            }
        }
    }
}