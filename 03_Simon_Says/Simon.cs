using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Simon_Says
{
    class Simon
    {
        public string Echo(string s)
        {
            return s.ToLower();
        }

        public string Shout(string s)
        {
            return s.ToUpper();
        }

        public string Repeat(string s, int repeats = 2)
        {
            string fullString = "";

            for(int i = 0; i < repeats; i++)
            {
                if (i != 0)
                    fullString += " ";

                fullString += Echo(s);
            }

            return fullString;
        }

        public string StartOfWord(string s, int chars)
        {
            return s.Substring(0, chars);
        }

        public string FirstWord(string s)
        {
            return s.Substring(0, s.IndexOf(" "));
        }

        public string Titleize(string s)
        {
            string[] splitString = s.Split( );

            for(int i = 0; i < splitString.Length; i++)
            {
                if(i == 0 || (splitString[i] != "the" && splitString[i] != "and" && splitString[i] != "over"))
                {
                    splitString[i] = UppercaseFirst(splitString[i]);
                }
            }

            return string.Join(" ", splitString);
        }

        public string UppercaseFirst(string s)
        {
            return s.Substring(0, 1).ToUpper() + s.Substring(1);
        }
    }
}
