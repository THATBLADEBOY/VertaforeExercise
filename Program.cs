using System;
using System.Collections.Generic;

namespace VertaforeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Question 1
            Write an application that satisfies the following:
            •          Small application
            •          Given a fully sorted array(ascending or descending), write a method to scramble the values
            e.g. (7, 13, 13, 18, 29, 33)
            •          Write the code with use-ability, debugging, and testing in mind.
            */

            Console.WriteLine("Question 1: Given a fully sorted array, write a method to scramble the values.");
            Console.Write("Input 7 numbers in the array :\n");
            int[] arr = new int[7];
            int i;
            for (i = 0; i < 7; i++)
            {
                Console.Write("number - {0} : ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Array.Sort(arr);
            Console.WriteLine("Sorted Array:");
            foreach(int number in arr)
            {
                Console.Write($"{number} ");
            }
            
            Methods.Pause();

            int[] RandomArray = Methods.Randomize(arr);
            Console.WriteLine("Scrambled Array:");
            foreach (int number in RandomArray)
            {
                Console.Write($"{number} ");
            }
            Methods.Pause();

            /*Question 2(2, 3, build off each other)

            * Consider the following style of abbreviation:
            *(first letter) +(count of removed letters) +(last letter)
            *For example:
            *"internationalization"-> "i18n"
            * "localization"-> "l10n"
            * Write a function that given a word returns its abbreviation.*/

            Console.WriteLine("Question 2: Write a function that given a word returns its abbreviation.");
            string name;
            Console.WriteLine("Enter your word: ");
            name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Your abbreviated word:");
            Console.WriteLine(Methods.Abbreviate(name));
            Methods.Pause();

            /*Question 3

            * Such abbreviations are not always unique, for example:
            *   "accessibility" -> "a11y"
            *   "automatically" -> "a11y"
            * Given a dictionary (a list of words), write a function that takes a word and
            * returns true if the abbreviation of the word is unique in the dictionary.
            *
            * For example, given a dictionary with the 4 words above:
            *   "internationalization" -> true
            *   "localization" -> true
            *   "accessibility" -> false
            *   "automatically" -> false
            */

            Console.WriteLine();
            Console.WriteLine("Question 3: Given a dictionary, write a function that takes a word and returns true if the abbreviation of the word is unique in the dictionary.");
            Console.WriteLine();
            Dictionary<string, string> WordsAndAbbreviations = new Dictionary<string, string>();
            string[] ArrayOfWords = { "accessibility", "automatically", "internationalization", "localization" };
            foreach(string word in ArrayOfWords)
            {
                string ABWord = Methods.Abbreviate(word);
                WordsAndAbbreviations.Add(word, ABWord);
            }
            Console.WriteLine("Dictionary of Words:");
            foreach(KeyValuePair<string, string> kvp in WordsAndAbbreviations)
            {
                Console.WriteLine(kvp);
            }
            Methods.Pause();
            Console.WriteLine();
            string WordToCompare;
            Console.WriteLine("Enter your word: ");
            WordToCompare = Console.ReadLine();
            Console.WriteLine();
            Methods.CheckUniqueness(WordToCompare, WordsAndAbbreviations);
            Methods.Pause();
        }  
    }
}
