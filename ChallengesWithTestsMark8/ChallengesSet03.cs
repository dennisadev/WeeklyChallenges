using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            for (int i = 0; i < vals.Length; i++)
            {
                if (vals[i] == false)
                {
                    return true;
                }
            }
            return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null || numbers.Count() == 0) 
            { 
                return false;
            }
            
            int sum = numbers.Sum();

            if ((sum % 2) != 0)
            {
                return true;
            }
            return false;
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool isLower = false;
            bool isUpper = false;
            bool isNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                { 
                    isLower = true;
                }
                
                if (char.IsUpper(password[i])) 
                { 
                    isUpper = true; 
                }

                if (char.IsNumber(password[i]))
                {  isNumber = true; 
                }    
            }

            if (isLower == true && isUpper == true && isNumber == true) 
            {
                return true;
            }
            return false;
        }

        public char GetFirstLetterOfString(string val)
        {
            return val[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return (val[val.Length - 1]);
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0) 
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];
        }

        public int[] GetOddsBelow100()
        {
           var oddList = new List<int>();

            for (int i = 0; i < 100; i++) 
            { 
                if ((i % 2) != 0) 
                { 
                    oddList.Add(i); 
                }
            }
            return oddList.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            { 
                words[i] = words[i].ToUpper();
            }
        }
    }
}
