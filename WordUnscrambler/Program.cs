﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Globalization;

namespace WordUnscrambler
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();

        static void Main(string[] args)
        {
            try
            {
                string question;
                string option;
                do {

                    do
                    {
                        Console.WriteLine("Enter scrambled word(s) manually or as a file: F - file / M - manual");

                        option = Console.ReadLine() ?? throw new Exception("String is empty");

                        switch (option.ToUpper())
                        {
                            case "F":
                                Console.WriteLine("Enter full path including the file name: ");
                                ExecuteScrambledWordsInFileScenario();
                                break;
                            case "M":
                                Console.WriteLine("Enter word(s) manually (separated by commas if multiple): ");
                                ExecuteScrambledWordsManualEntryScenario();
                                break;
                            default:
                                Console.WriteLine("The entered option was not recognized.");
                                break;
                        }
                    } while (option.ToUpper() != "F" || option.ToUpper() != "M");
                    Console.WriteLine("Do you wish to continue Y/N");
                    question = Console.ReadLine();
                    

                }while (question.ToUpper() != "Y");
            }
            catch (Exception ex)
            {
                Console.WriteLine("The program will be terminated." + ex.Message);

            }
        }

        private static void ExecuteScrambledWordsInFileScenario()
        {
            var filename = Console.ReadLine();
            string[] scrambledWords = _fileReader.Read(filename);
            DisplayMatchedUnscrambledWords(scrambledWords);
        }

        private static void ExecuteScrambledWordsManualEntryScenario()
        {
            
        }

        private static void DisplayMatchedUnscrambledWords(string[] scrambledWords)
        {
            //read the list of words from the system file. 
            string[] wordList = _fileReader.Read("wordlist.txt");

            //call a word matcher method to get a list of structs of matched words.
            List<MatchedWord> matchedWords = _wordMatcher.Match(scrambledWords, wordList);

            foreach (object word in matchedWords)
            {
                Console.WriteLine(word);
            }




        }
    }
}


