using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Source
{
    public class CharComparator
    {
        List<char> _charList = new List<char>();
        char[] _englishLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        public char GetBiggestChar(char a, char b)
        {
            _charList.Add(a);
            _charList.Add(b);

            return _charList.Max();
        }

        public int GetNumberOfOcurrences(char a, string b)
        {
            int output = 0;
            foreach (var item in b)
            {
                if (item == a)
                {
                    output++;
                }
            }
            return output;
        }

        public string GetIllegalChars(string a)
        {
            Regex regex = new Regex("([^A-Za-z])", RegexOptions.IgnoreCase);
            MatchCollection matches = regex.Matches(a);
            string output = "";


            foreach (Match match in matches)
            {
                output += match;
            }

            return output;
        }
    }
}
