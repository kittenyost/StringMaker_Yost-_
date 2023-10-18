using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMaker_Yost
{
    internal class StringManager
    {
        public string CurrentInput { get; set; } = "";

        public string Reverse(string s)
        {
            CurrentInput = s;
            string reversedStr = "";
            Stack<char> myStack = new Stack<char>();
            foreach (char t in s)
            {
                myStack.Push(t);
            }
            while (myStack.Count > 0)
            {
                reversedStr += myStack.Pop();
            }
            return reversedStr;
        }

        public string Reverse(string s, bool PreserveCaseLocation)
        {
            CurrentInput = s;
            string reverseString = Reverse(s);
            string resultString = "";
            for (int i = 0; i < s.Length; i++)
            {
                if (char.IsUpper(s[i]))
                {
                    resultString += char.ToUpper(reverseString[i]);
                }
                else
                {
                    resultString += char.ToLower(reverseString[i]);
                }
            }
            return resultString;
        }

        public bool Symmetric(string s)
        {
            CurrentInput = s;
            return s == Reverse(s);
        }

        public override string ToString()
        {
            if (string.IsNullOrEmpty(CurrentInput))
            {
                return "Negative One";
            }

            int asciiTotal = 0;
            for (int i = 0; i < CurrentInput.Length; i++)
            {
                asciiTotal += Convert.ToInt32(CurrentInput[i]);
            }

            string numberString = asciiTotal.ToString();

            string resultString = "";
            Dictionary<char, string> dictNumbers = new Dictionary<char, string>()
            {
                { '0', "Zero" },
                { '1', "One" },
                { '2', "Two" },
                { '3', "Three" },
                { '4', "Four" },
                { '5', "Five" },
                { '6', "Six" },
                { '7', "Seven" },
                { '8', "Eight" },
                { '9', "Nine" }
            };
            for (int i = 0; i < numberString.Length; i++)
            {
                resultString += dictNumbers[numberString[i]] + " ";
            }

            return resultString.Trim();
        }

        public override bool Equals(object? obj)
        {
            return CurrentInput.Equals(obj);
        }
    }
}
