using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata.Ecma335;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //Check if char is in the alphabet
            //normalize data by lowercasing
            //create array of all lower case chars
            //determine if a char if so make true if not make false
            //return answer
            char letter = char.ToLower(c);
            string lowercaseAlphabet = "abcdefghijklmnopqrstuvwxyz";
            foreach (char i in lowercaseAlphabet)
            {
                if (letter == i)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            //Determine if count of elements is even (true) or odd (false)
            //use array.Length to find number of elements and store in variable
            //use variable in an if else statement (if even return true else return false)
            int count = vals.Length;
            return (count % 2 == 0);
            
        }

        public bool IsNumberEven(int number)
        {
            return (number % 2 == 0);
        }

        public bool IsNumberOdd(int num)
        {
            return (num % 2 != 0);
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0 )
            { 
                return 0; 
            }

            return numbers.Min() + numbers.Max();
            
            

        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            //Find which string is shorter and return that string
            //Find length of str1 and store in an int
            //Find length of str2 and store in an int
            //make an if statement to return shorter of the two strings

            int str1Length = str1.Length;
            int str2Length = str2.Length;
            if (str1Length < str2Length)
            {
                return str1Length;
            }
            return str2Length;
        }

        public int Sum(int[] numbers)
        {
            //Find sum of the numbers in array numbers
            //iterate through the array
            //add each number together and create an int named sum
            //return sum
            
            if (numbers == null)
            {
                return 0;                
            }
            return numbers.Sum();
            
            
        }

        public int SumEvens(int[] numbers)
        {
            //find the sum of even numbers only
            //iterate through array
            //find numbers that are even
            //add together numbers that are even and store in an int named sum
            //return sum

            
                while (numbers != null)
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        sum += numbers[i];
                    }
                    
                }
                return sum;
            }
            return 0;
            
        }

        public bool IsSumOdd(List<int> numbers)
        { 
            

            if ( numbers == null)
            {                              
                return false;
            }
            return (numbers.Sum()% 2 !=0);
        } 
        

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            while (number > 0)
            {
                int count = 0;
                for (int i = 1; i < number; i += 2)
                {
                    count++;
                }
                return count;
            }
            return 0;
        }
    }
}
