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

            foreach (string scrambleword in scrambledWords)
            {
                foreach (string word in wordList)
                {
                    char[] char1 = scrambleword.ToCharArray();
                    char[] char2 = word.ToCharArray();


                    if (char1.SequenceEqual(char2))
                    {
                        MatchedWord matchedWord = new MatchedWord
                        {
                            ScrambledWord = scrambleword,
                            Word = word
                        };
                        matchedWords.Add(matchedWord);

                    }


                }
                return matchedWords;
            }

            // Work with "scrambledWords" and "matchedWords".

            MatchedWord BuildMatchedWord(string scrambledWord, string word)
            {
                // Build a matched-word object here, so that you can return it.

                //return matchedWord;
                return new MatchedWord();  // Delete this line when done.
            }

            return matchedWords;
        }
    }


}

