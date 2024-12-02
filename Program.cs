using System.Security.Cryptography.X509Certificates;

namespace Assignment_5_1_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 5.1.1
             * 
             * Given an integer x, return true if x is a palindrome, and false otherwise.
             * 
             * Example 1:
             * Input: x = 121
             * Output: true
             * Explanation: 121 reads as 121 from left to right and from right to left.
             * 
             * Example 2:
             * Input: x = -121
             * Output: false
             * Explanation: From left to right, it reads -121. From right to left, it becomes 121-. 
             * Therefore it is not a palindrome.
             */

            int x = -131;

            Console.WriteLine(IsPalindrome(x.ToString()).ToString());
        }

        public static bool IsPalindrome(string StringInts_)
        {
            bool result = true;
            int start = 0;
            int end = StringInts_.Length - 1;

            while (start < end)
            {
                
                // A letter did not match
                if (StringInts_[start] != StringInts_[end])
                {
                    result = false;
                    break;
                }

                start++; end--;
            }

            return result;
        }
    }
}
