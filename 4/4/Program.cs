using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4
{    static class StringHelper
    {
        /// <summary>
        /// Receives string and returns the string with its letters reversed.
        /// </summary>
        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int palindrome = 0;
            for(int i = 1; i <= 999; i++)
            {
                for(int x = 1; x <= 999; x++)
                {
                    int mult = i * x;
                    if (mult.ToString() == StringHelper.ReverseString(mult.ToString()) && mult > palindrome)
                        palindrome = mult;                    
                }
            }
            Console.WriteLine(palindrome.ToString());
            Console.ReadKey();
        }
    }
}
