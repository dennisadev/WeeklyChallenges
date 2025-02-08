using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {

            bool containsWord = false;

            if (words == null || words.Contains(null)) 
            {
                return false;
            }

            if (ignoreCase)
            { 
                word = word.ToLower();
                List<string> wordsLower = words.Select(x => x.ToLower()).ToList();
                
                containsWord = wordsLower.Contains(word);
            }

            if (!ignoreCase) 
            {
                containsWord = words.Contains(word);
            }

            return containsWord;

        }

        public bool IsPrimeNumber(int num)
        {

            if (num == 2 || num == 3)
            {
                return true;
            }

            if (num == 1) 
            {
                return false;
            }

            if (num >= 0 && num % 2 != 0 && num % 3 != 0) 
            {
                return true;
            }

            return false;
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            int result = -1;
            bool uIndex = false;
            
            for (int i = 0; i < str.Length; i++)
            {
                uIndex = true;

                for (int j = 0; j < str.Length; j++)
                {
                    if (str[i] == str[j] && i != j)
                    { 
                        uIndex = false;
                    }
                }

                if (uIndex) 
                { 
                    result = i;
                }
            }

            return result;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int max = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;

                for (int j = i +1; j < numbers.Length; j++)
                {
                    if (numbers[i] != numbers[j]) 
                    {
                        break;
                    }
                    
                    currentCount++;
                }

                if (currentCount > max) 
                { 
                    max = currentCount;
                }
            }

            return max;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            var result = new List<double>();

            if (elements == null || n <= 0 || n > elements.Count)
            { 
                return result.ToArray();
            }

            for (int i = n - 1; i < elements.Count; i += n)
            { 
                result.Add(elements[i]);
            }

            return result.ToArray();
        }
    }
}
