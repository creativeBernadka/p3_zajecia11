using System;
using System.Linq;

namespace zajecia11
{
    public static class ExtensionMethods
    {
        public static (int, int) Divide(this int dividend, int divider)
        {
            return (dividend / divider, dividend % divider);
        }
        
        public static int CountSymbolOccurrences(this string text, char symbol)
        {
            return text.Count(character => character == symbol);
        }
        
        public static int CountSymbolOccurrences(this string text, char symbol, bool caseInvariant = false)
        {
            if (caseInvariant)
            {
                return text.Count(character =>
                {
                    return char.ToLower(character) == char.ToLower(symbol);
                });
            }

            return text.CountSymbolOccurrences(symbol);
        }

        public static int PersonTypeSum(this PersonType personType)
        {
            int sum = 0;
            foreach (var item in Enum.GetValues(typeof(PersonType)))
            {
                sum += (int) item;
            }
            
            return sum;
        }
    }
}