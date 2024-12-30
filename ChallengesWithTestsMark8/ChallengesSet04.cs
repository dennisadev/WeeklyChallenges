using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var strList = new List<int> {str1.Length, str2.Length, str3.Length, str4.Length};
            return strList.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numberList = new List<int> { number1, number2, number3, number4 };
            return numberList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 > sideLength3 && sideLength1 +sideLength3 > sideLength2 && sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }
            return false;
        }

        public bool IsStringANumber(string input)
        {
            var isNum = double.TryParse(input, out double num);
            return isNum;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            
            foreach (var obj in objs)
            {
                if (obj == null) 
                    {
                    nullCount++;
                    }
            }

            if (nullCount >= objs.Length / 2 + 1) 
            { 
                return true;
            }
            return false;

        }

        public double AverageEvens(int[] numbers)
        {

           if (numbers == null)
           {
                return 0;
           }

            var evenNumbers = numbers.Where(x => x % 2 == 0);

            if (evenNumbers.Count() == 0)
            {
                return 0;
            }


            return evenNumbers.Average();
        }

        public int Factorial(int number)
        {
            if (number == 0) 
            {
                return 1;
            }

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            return number * Factorial(number - 1);
        }
    }
}
