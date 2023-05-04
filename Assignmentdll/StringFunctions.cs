using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Assignmentdll
{
    public class StringFunctions
    {
        public  int CountChars(string str) {return str.Length;}

        public  string ChangeToUpper(string str) { return str.ToUpper();}

        public  string AddSentences(string str1, string str2) {
            return str1 +" "+ str2;
        }

        public  string ReverseSentence(string str) {
            string[] words = str.Split(' '); 
            Array.Reverse(words);   
            return string.Join(" ", words);
        }

        public bool IsPallindrome(string str) {
            char[] revstr = str.ToCharArray();
            Array.Reverse(revstr);
            if (string.Join("",revstr) == str) { 
            return true;
            }
            return false;   
        }

        public int CountWords(string str) {
            return str.Trim().Split(" ").Count();
        }

        public string RemoveExtraSpaces(string input)
        {
            string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            return string.Join(" ", words);
        }


        public bool SearchForSubstring(string sentence, string substring)
        {
            return sentence.Contains(substring);
        }

        public int CountSubstringOccurrences(string sentence, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = sentence.IndexOf(substring, index, StringComparison.CurrentCultureIgnoreCase)) != -1)
            {
                count++;
                index += substring.Length;
            }

            return count;
        }

        public string ToProperCase(string sentence)
        {
            TextInfo textInfo = CultureInfo.CurrentCulture.TextInfo;
            return textInfo.ToTitleCase(sentence);
        }

        public void CountCharacters(string sentence, out int vowels, out int consonants, out int integers, out int specialChars)
        {
            vowels = consonants = integers = specialChars = 0;
            foreach (char c in sentence)
            {
                if (Char.IsLetter(c))
                {
                    if (IsVowel(c))
                    {
                        vowels++;
                    }
                    else
                    {
                        consonants++;
                    }
                }
                else if (Char.IsDigit(c))
                {
                    integers++;
                }
                else
                {
                    specialChars++;
                }
            }
        }


        static bool IsVowel(char c)
        {
            char lowerC = Char.ToLower(c);
            return lowerC == 'a' || lowerC == 'e' || lowerC == 'i' || lowerC == 'o' || lowerC == 'u';
        }

    }
}
