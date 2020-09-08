using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercice2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            isPalindromeArr();
            isPalindromeForEach();
            isPalindromeFor();
        }
        private void isPalindromeArr()
        {
            string palindrome = txtPalindrome.Text;
            char[] array = palindrome.ToCharArray();
            string first = palindrome.Substring(0, palindrome.Length / 2);

            Array.Reverse(array);

            string temp = new string(array);
            string second = temp.Substring(0, temp.Length / 2);

            if (first.Equals(second))
            {
                lblPalArr.Text = $"{palindrome} est un palindrome.";
            }
            else
            {
                lblPalArr.Text = $"{palindrome} n'est pas un palindrome.";
            }
        }

        private void isPalindromeForEach()
        {
            string palindrome = txtPalindrome.Text;
            char[] array = palindrome.ToCharArray();
            Array.Reverse(array);
            string temp = "";

            foreach (char letter in array)
            {
                temp += letter;
            }

            if(validatePalindrome(palindrome, temp))
            {
                lblPalForEach.Text = $"{palindrome} est un palindrome.";
            }
            else
            {
                lblPalForEach.Text = $"{palindrome} n'est pas un palindrome.";
            }
        }

        private void isPalindromeFor()
        {
            string palindrome = txtPalindrome.Text;
            char[] array = palindrome.ToCharArray();
            Array.Reverse(array);
            string temp = "";

            for (int i = 0; i < array.Length; i++)
            {
                temp += array[i];
            }

            if (validatePalindrome(palindrome, temp))
            {
                lblPalFor.Text = $"{palindrome} est un palindrome.";
            }
            else
            {
                lblPalFor.Text = $"{palindrome} n'est pas un palindrome.";
            }
        }
        private Boolean validatePalindrome(string palindrome, string temp)
        {
            if (temp.Equals(palindrome))
            {
                MessageBox.Show("Oui");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
