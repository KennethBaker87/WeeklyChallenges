using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            //sum the evens, sum the odds and subtract them from the sum of the evens
            int sum = 0;
            int dif = 0;

            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                }
                else
                {
                    dif += i;
                }

            }
            return sum - dif;

        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            string shortest;
            if (str1.Length < str2.Length)
            {
                shortest = str1;
            }
            else { shortest = str2; }

            if (shortest.Length > str3.Length)
            {
                shortest = str3;
            }
            if (shortest.Length > str4.Length)
            {
                shortest = str4;
            }
            return shortest.Length;


        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //find the smallest number between the given ints
            //create a list of ints
            //return the .Min int

            List<int> numbers = new List<int>();
            numbers.Add(number1);
            numbers.Add(number2);
            numbers.Add(number3);
            numbers.Add(number4);
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";


        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 + sideLength2 <= sideLength3 ||
                sideLength1 + sideLength3 <= sideLength2 ||
                sideLength2 + sideLength3 <= sideLength1)
            {
                return false;
            }
            return true;
        }

        public bool IsStringANumber(string input)
        {
            if (input == null)
            {
                return false;
            }
            return double.TryParse(input, out double k);
            throw new NotImplementedException();
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int nullCount = 0;
            int objsHalf = objs.Length / 2;
            foreach (object obj in objs)
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }
            if (nullCount > objsHalf)
            {
                return true;
            }
            return false;



        }

        public double AverageEvens(int[] numbers)
        {
            //find the average of the sum of all even numbers in array numbers
            //create an double to hold sum of all even numbers
            //iterate through the array
            //if % 2 == 0 += sum
            //return sum.Average
            if (numbers == null)
            {
                return 0;
            }
            double sum = 0;
            double avera = 0;
            foreach (int i in numbers)
            {
                if (i % 2 == 0)
                {
                    sum += i;
                    avera++;
                }


            }
            if (sum == 0)
            {
                return 0;
            }

            return sum / avera;


        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException("number");
            }
            if (number <= 1)
            {
                return 1;
            }
            
            
             return number * Factorial(number - 1);
            
            

            

        }
    }
}
