using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PalindromeWordCheck
{
   public partial  class Program
    {
        public static bool IsPalindrome(string word)
        {
            try
            { 
                int min = 0;
                int max = word.Length - 1;
                while (true) {
                    if (min > max) {
                        return true;
                    }
                    char a = word[min];
                    char b = word[max];
                    if (char.ToLower(a) != char.ToLower(b)) {
                        return false;
                    }
                    min++;
                    max--;
                }
           }
            catch(Exception ex) {                
                Console.WriteLine("Error : {0}",ex.Message);
                return false;
            }

       }
        public static void check(string word,bool shouldbepolindrome)
        {
            string input = word.Replace(" ", string.Empty);
            Console.WriteLine(IsPalindrome(input) == shouldbepolindrome?"Pass":"Fail");

        }
        static void Main(string[] args)
        {
            check("abcba", true);
            check("abcde", false);
            check("Mr owl ate my metal worm", true);
            check("Never Odd Or Even", true);
            check("Never Even Or Odd", false);
            Console.ReadLine();

        }
    }
}
