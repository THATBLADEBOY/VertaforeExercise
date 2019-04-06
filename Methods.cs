using System;
using System.Collections.Generic;
using System.Linq;

namespace VertaforeChallenges
{
    public class Methods
    {
        public static void Pause()
        {
            Console.WriteLine();
            Console.Write("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
        }

        public static int[] Randomize(int[] NumberList)
        {
            Random rnd = new Random();
            int[] MyRandomArray = NumberList.OrderBy(x => rnd.Next()).ToArray();
            return MyRandomArray;
        }

        public static string Abbreviate(string GivenWord)
        {
            char GWFirstCharacter = GivenWord[0];
            char GWLastCharacter = GivenWord[GivenWord.Length - 1];
            int RemovedCount = GivenWord.Count() - 2;
            string AbbreviatedString = $"{GWFirstCharacter}{RemovedCount}{GWLastCharacter}";
            return AbbreviatedString;
         }

        public static void CheckUniqueness(string wtc, Dictionary<string, string> waa)
        {
            Dictionary<string, bool> WordsAndUniqueness = new Dictionary<string, bool>();
            string WordToCompare = wtc;
            foreach (KeyValuePair<string, string> kvp in waa)
            {
                bool AbIsUnique = true;
                if (Abbreviate(WordToCompare) == kvp.Value)
                {
                    AbIsUnique = false;
                }
                WordsAndUniqueness.Add(kvp.Key, AbIsUnique);
                ;
            }
            if (WordsAndUniqueness.ContainsValue(false))
            {
                Console.WriteLine($"The abbreviation of {WordToCompare} is not unique.");
            }
            else
            {
                Console.WriteLine($"The abbreviation of {WordToCompare} '{Abbreviate(WordToCompare)}' is unique.");
            }
        }
    }
}
