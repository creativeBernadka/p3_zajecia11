using System;

namespace zajecia11
{
    class Program
    {
        static void Main(string[] args)
        {
            // int number = Convert.ToInt32(Console.ReadLine());
            //
            // (int result, int rest) = number.Divide(3);
            //
            // Console.WriteLine($"{number}/3 = {result} rest {rest}");
            
            // string text = Console.ReadLine();
            //
            // int numberOfSymbols = text.CountSymbolOccurrences('a', true);
            //
            // Console.WriteLine($"In text: {text} \nsymbol \"a\" occurs {numberOfSymbols} times.");
            
            Advert advert = new Advert(
                "Tresc reklamy", 
                PersonType.Child | PersonType.Teenager, 
                Interests.Gaming);
            
            advert.Test();
        }
    }
}