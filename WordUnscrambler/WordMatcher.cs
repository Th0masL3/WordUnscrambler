using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class WordMatcher
    {
        public List<MatchedWord> Match(string[] scrambledWords, string[] wordList)
        {
            List<MatchedWord> matchedWords = new List<MatchedWord>();

            foreach (string scrambledWord in scrambledWords)
            {
                char[] characters = scrambledWord.ToCharArray();

                foreach (string word in wordList)
                {
                    int count = 0;

                    foreach (char c in characters)
                    {
                        if (word.Length == characters.Length && word.ToLower().Contains(Char.ToLower(c)))
                        {
                            count++;
                        }

                        if (count == characters.Length) matchedWords.Add(BuildMatchedWord(scrambledWord, word));


                    }

                }

            }

            // Work with "scrambledWords" and "matchedWords".

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                // Build a matched-word object here, so that you can return it.

                //return matchedWord;
                return new MatchedWord { ScrambledWord = scrambledWord, Word = word };
            }

            return matchedWords;
        }
    }

}