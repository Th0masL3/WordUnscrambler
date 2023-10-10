using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    internal static class ExtensionMethods
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        
        public static void ExecuteScrambledWordsInFileScenario()
        {
            var filename = Console.ReadLine();
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        public static void ExecuteScrambledWordsManualEntryScenario()
        {
            Console.WriteLine("Enter word(s) manually (separated by commas if multiple): ");
            string[] wordArray = Console.ReadLine().Split(',');

            Console.WriteLine("Enter scrambled word(s) manually(separated by commas if multiple): ");
            string[] scrambledWordArray = Console.ReadLine().Split(',');


        }


        public static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words from the system file. 
            string[] wordList = _fileReader.Read("wordlist.txt");

            //call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            foreach (MatchedWord word in matchedWords)
            {
                Console.WriteLine($"scrambledWord :   {word.ScrambledWord}   matched with the word :   {word.Word}");
            }
        }
    }
}
