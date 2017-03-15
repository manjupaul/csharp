using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class PalindromeCheck
    {
        public void FirstMethod(string str)
        {
            string revs = "";
            for (int i = str.Length - 1; i >= 0; i--) //String Reverse
            {
                revs += str[i].ToString();
            }
            if (revs == str) // Checking whether string is palindrome or not
            {
                Console.WriteLine("String is Palindrome \n Entered String Was {0} and reverse string is {1}", str, revs);
            }
            else
            {
                Console.WriteLine("String is not Palindrome \n Entered String Was {0} and reverse string is {1}", str, revs);
            }
        }

    }
        class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Enter the string");
                string str = Console.ReadLine();
                PalindromeCheck obj = new PalindromeCheck();
                obj.FirstMethod(str);
                Console.ReadLine();
            }
        }
    }
