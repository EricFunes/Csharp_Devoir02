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
            isPalindromeForEach(ref palindrome);
            isPalindromeFor(ref palindrome);
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
                Console.WriteLine($"{palindrome} est un palindrome.");
                return true;
            }
            else
            {
                Console.WriteLine($"{palindrome} n'est pas un palindrome.");
                return false;
            }
        }

        private static void isPalindromeForEach(ref string palindrome)
        {
            char[] array = palindrome.ToCharArray();
            Array.Reverse(array);
            string temp = "";

            foreach (char letter in array)
            {
                temp += letter;
            }

            validatePalindrome(palindrome, temp);
        }

        private static void isPalindromeFor(ref string palindrome)
        {
            char[] array = palindrome.ToCharArray();
            Array.Reverse(array);
            string temp = "";

            for (int i = 0; i < array.Length; i++)
            {
                temp += array[i];
            }

            validatePalindrome(palindrome, temp);
        }

        private static Boolean validatePalindrome(string palindrome, string temp)
        {
            if (temp.Equals(palindrome))
            {
                Console.WriteLine($"{palindrome} est un palindrome.");
                return true;
            }
            else
            {
                Console.WriteLine($"{palindrome} n'est pas un palindrome.");
                return false;
            }
        }
    }
}
