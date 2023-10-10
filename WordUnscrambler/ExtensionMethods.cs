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
            DisplayMatchedUnscrambledWords(scrambledWords, null);
        }

        public static void ExecuteScrambledWordsManualEntryScenario()
        {
            Console.WriteLine("Enter word(s) manually (separated by commas if multiple): ");
            string[] wordsArray = Console.ReadLine().Split(',');

            Console.WriteLine("Enter scrambled word(s) manually(separated by commas if multiple): ");
            string[] scrambledWordArray = Console.ReadLine().Split(',');

            DisplayMatchedUnscrambledWords(scrambledWordArray, wordsArray);
        }


        public static void DisplayMatchedUnscrambledWords(string[] scrambledWords, string[] wordsArray)
        {

            List<MatchedWord> matchedWords = new List<MatchedWord>();
            
            if(wordsArray is null)
            {
                //read the list of words from the system file. 
                string[] wordList = _fileReader.Read("unscrambledWords.txt");

                //call a word matcher method to get a list of structs of matched words.
                matchedWords = _wordMatcher.Match(scrambledWords, wordList);
            }

            else
            {
                matchedWords = _wordMatcher.Match(scrambledWords, wordsArray);
            }

            foreach (MatchedWord word in matchedWords)
            {
                Console.WriteLine($"scrambledWorld :  {word.ScrambledWord}  matched with the word :  {word.Word}");
            }
        }
    }
}
