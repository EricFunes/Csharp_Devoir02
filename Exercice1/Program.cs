using System;
using System.Collections;
using System.Linq;

namespace Exercice1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palindrome = "";

            while (isWordNull(ref palindrome) != true) { };
            isPalindromeArr(ref palindrome);
        }

        private static Boolean isWordNull(ref string palindrome)
        {
            Console.WriteLine("Écrivez un mot: ");
            palindrome = Console.ReadLine();

            while (String.IsNullOrWhiteSpace(palindrome))
            {
                return false;
            }
            return true;
        }
        private static Boolean isPalindromeArr(ref string palindrome)
        {
            char[] array = palindrome.ToCharArray();
            string first = palindrome.Substring(0, palindrome.Length / 2);

            Array.Reverse(array);

            string temp = new string(array);
            string second = temp.Substring(0, temp.Length / 2);

            if (first.Equals(second))
            {
                Console.WriteLine("Success");
                return true;
            }
            else
            {
                Console.WriteLine("Fail");
                return false;
            }
        }
    }
}
