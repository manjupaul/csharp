using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{//String reverse
    class Reverse
    {
        internal void reverseStr(string str1)
        {
            int length = str1.Length - 1;
            string RevStr = "";
            while (length >= 0)
            {
                RevStr = RevStr + str1[length];
                length--;
            }
            Console.Write("Reverse of string " + RevStr);

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            string str = Console.ReadLine();
            Reverse obj = new Reverse();
            obj.reverseStr(str);
            Console.ReadLine();
        }
    }
}



