using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CodeWars
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        /// <summary>
        /// A method that converts a phrase to upper or lower case depending on the conditions:
        ///- if the number of letters in upper case is more than in lower case, the phrase is converted to upper case;
        ///- if the number of uppercase letters is equal to the number of lowercase letters, then the phrase is converted to lowercase;
        ///- if the number of uppercase letters is less than the number of lowercase letters, then the phrase is converted to lowercase.
        /// </summary>
        /// <param name="phrase">Phrase to convert</param>
        /// <returns>Transformed phrase</returns>
        public static string Solve(string phrase)
        {
            var lower = Regex.Matches(phrase, @"(\p{Ll})");
            var upper = Regex.Matches(phrase, @"(\p{Lu})");
            if (lower.Count == upper.Count)
            {
                return phrase.ToLower();
            }
            else if (lower.Count > upper.Count)
            {
                return phrase.ToLower();
            }
            else
            {
                return phrase.ToUpper();
            }
        }
        /// <summary>
        /// A method that accepts a string as input, replace each letter with an ordinal number in the alphabet
        /// If something in the text is not a letter, then this character is ignored and not returned
        /// </summary>
        /// <param name="text">Input text</param>
        /// <returns></returns>
        private static string AlphabetPositionEn(string text)
        {
            char[] sumbol = new char[] {
                '\n', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l',
                'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'
            };
            List<int> list = new List<int>();
            string convertV = text.ToLower();
            foreach (char item in convertV)
            {
                int c = Array.IndexOf(sumbol, item);
                if (c != -1 && c != 0) list.Add(c);
            }
            text = string.Join(" ", list);
            Console.WriteLine(text);
            return text;
        }
    }
}
