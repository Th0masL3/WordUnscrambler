using System;
using System.CodeDom.Compiler;
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
        
        

        public static void ExecuteScrambledWordsInFileScenario(string language)
        {
                var filename = Console.ReadLine();
                string[] scrambledWordsArray = _fileReader.Read(filename);
                DisplayMatchedUnscrambledWords(scrambledWordsArray, null, language);  
        }

        public static void ExecuteScrambledWordsManualEntryScenario(string language)
        {
            if (language == "Y")
            {

                Console.WriteLine(Properties.stringsfr_CA.WordsPrompt);
                string[] wordsArray = Console.ReadLine().Split(',');

                Console.WriteLine(Properties.stringsfr_CA.ScrambledWordPrompt);
                string[] scrambledWordsArray = Console.ReadLine().Split(',');

                DisplayMatchedUnscrambledWords(scrambledWordsArray, wordsArray, language);

            }

            else
            {
                Console.WriteLine(Properties.strings.WordsPrompt);
                string[] wordsArray = Console.ReadLine().Split(',');

                Console.WriteLine(Properties.strings.ScrambledWordPrompt);
                string[] scrambledWordsArray = Console.ReadLine().Split(',');

                DisplayMatchedUnscrambledWords(scrambledWordsArray, wordsArray, language);

            }

           
        }


        public static void DisplayMatchedUnscrambledWords(string[] scrambledWordsArray, string[] wordsArray, string language)
        {
            
            if (language == "Y")
            {
                List<MatchedWord> matchedWords = new List<MatchedWord>();

                if (wordsArray is null)
                {
                    //read the list of words from the system file. 
                    string[] wordList = _fileReader.Read("unscrambledWords.txt");

                    //call a word matcher method to get a list of structs of matched words.
                    matchedWords = _wordMatcher.Match(scrambledWordsArray, wordList);
                }

                else
                {
                    matchedWords = _wordMatcher.Match(scrambledWordsArray, wordsArray);
                }

                foreach (MatchedWord word in matchedWords)
                {
                    Console.WriteLine($"mot brouillé :  {word.ScrambledWord} est associé au mot :  {word.Word}");
                }
            }
           
            else
            {
                List<MatchedWord> matchedWords = new List<MatchedWord>();

                if (wordsArray is null)
                {
                    //read the list of words from the system file. 
                    string[] wordList = _fileReader.Read("unscrambledWords.txt");

                    //call a word matcher method to get a list of structs of matched words.
                    matchedWords = _wordMatcher.Match(scrambledWordsArray, wordList);
                }

                else
                {
                    matchedWords = _wordMatcher.Match(scrambledWordsArray, wordsArray);
                }

                foreach (MatchedWord word in matchedWords)
                {
                    Console.WriteLine($"scrambled word :  {word.ScrambledWord}  matched with the word :  {word.Word}");
                }


            }
            
        }
    }
}
