using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
           
            if(Array.Exists(vals, element => element == false))
            {
                
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int? odd = numbers.Sum();
                     
                if (odd % 2 == 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
                     
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool Upper = password.Any(char.IsUpper);
            bool lower = password.Any(char.IsLower);
            bool num = password.Any(char.IsDigit);
            if (Upper && lower && num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public char GetFirstLetterOfString(string val)
        {
             char FirstLetter = val.FirstOrDefault();
            return FirstLetter;
        }

        public char GetLastLetterOfString(string val)
        {
            char LastLetter = val.LastOrDefault();
            return LastLetter;
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                 return dividend / divisor;
                
            }            
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums.First();
        }

        public int[] GetOddsBelow100()
        {
            return Enumerable.Range(1, 100).Where(x => x % 2 != 0).ToArray();
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
