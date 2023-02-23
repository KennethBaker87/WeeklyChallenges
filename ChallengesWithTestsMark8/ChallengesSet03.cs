using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals) //DONE
        {
            //make sure no matter the reults bool returns false
            //iterate through array
            //if null return false
            //return all other values false

            foreach (var val in vals)
            {
                if (val == false)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers) //DONE
        {
            //return the sum of only the odd numbers in IEnumerable
            //create an int to store added numbers
            //iterate through numbers
            //only add odd numbers 
            //create an if statement to return true if created int it odd or false if created int is even
            int sum = 0;
            if (numbers == null)
            {
                return false;
            }

            foreach (var num in numbers)
            {
                
                                     
                
                if (num % 2 != 0)
                {
                    sum += num;
                }
                continue;

            }
            

                if (sum %2 != 0)
            {
                return true;
            }
            return false;
            
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            //Fake Password = KjrUt7
            //iterate through string password
            //Create a check that password contains uppercase lowercase and numbers in it
            //Create an if statement that looks for lowercase && upercase && numbers and have return true
            //Else return false
            bool upper = false;
            bool lower = false;
            bool numb = false;
            foreach (char letter in password)
            {
                if (Char.IsUpper(letter))
                {
                    upper = true;
                }
                else if (Char.IsLower(letter))
                {
                    lower = true;
                }
                else if (Char.IsNumber(letter)) 
                {
                    numb = true;
                }
                
            }
            return (upper && lower && numb);
            
            
        }

        public char GetFirstLetterOfString(string val)
        {
            //return the first letter of string val
            //return first index value
            return val.ToCharArray()[0];
            
        }

        public char GetLastLetterOfString(string val)
        {
            //return the last letter of string val
            //return last index of string.Length
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor) //DONE
        {
            //divide dividend by divisor
            //create an if statement for if dividend or divisor == 0 return 0
            //return dividen divided by divisor
            if ( divisor == 0)
                {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            //subtract the last number in nums by the first number in numbs
            //return the last number (nums.Length) minus index 0
            int lastIndex = nums.Length - 1;
            int ans = nums[lastIndex] - nums[0];
            return ans;
            
        }

        public int[] GetOddsBelow100()
        {
            //return all odd numbers below 100 in a given array
            //create an array of numbers between 1 - 100
            //iterate through the array
            //
            int[] odd = new int[0];
            int i = 1;
            while (i < 100)
            {
                if (i % 2 !=0)
                {
                    odd = odd.Append(i).ToArray();
                    
                }
                i++;
            }
            return odd; 





        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            //change all letters in elements in words to uppercase
            //iterate through array
            //return all to uppercase
            
            for (int i = 0; i < words.Length;i++)
            {
                words[i] = words[i].ToUpper();
            }
        }
    }
}
