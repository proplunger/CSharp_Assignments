using Assignmentdll;

namespace AssignmentdllConsume
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NumericFunctions numericFunctions = new NumericFunctions();
            StringFunctions stringFunctions = new StringFunctions();

            //display even numbers in range
            List<int> resulteven = numericFunctions.EvenRange(4, 80);
            //foreach (int i in resulteven)
            //{
            //    Console.WriteLine(i);
            //}

            //display odd numbers in range
            List<int> resultodd = numericFunctions.OddRange(4, 80);
            //foreach (int i in resultodd)
            //{
            //    Console.WriteLine(i);
            //}

            //display prime numbers in range
            List<int> resultprime = numericFunctions.PrimeRange(0, 80);
            //foreach (int i in resultprime)
            //{
            //    Console.WriteLine(i);
            //}

            //reverse a number
            //Console.WriteLine(numericFunctions.ReverseNum(123));

            //displayTable
            //Console.WriteLine(numericFunctions.NumTable(2));

            //Console.WriteLine(numericFunctions.TableRange(2,5));
            //Console.WriteLine(numericFunctions.TableRangeInRange(2,5,1,5));

            //IsPallindrome
            //Console.WriteLine(stringFunctions.IsPallindrome("121"));

            //CountWOrds
            //Console.WriteLine(stringFunctions.CountWords("My name is Karan."));

            //RemoveExtraSpaces
            //Console.WriteLine(stringFunctions.RemoveExtraSpaces(" This   is is  extra space     string. ")) ;

            //Change sentence to Proper case.
            //Console.WriteLine(stringFunctions.ToProperCase("covert this string to proper case."));

            //Search for a given Substring
            //Console.WriteLine(stringFunctions.SearchForSubstring("This is the main string.","the"));

            //count no. of occurences of a substring in a string
            //Console.WriteLine(stringFunctions.CountSubstringOccurrences("The fox jumped over the box.","the"));

            //Count no. of vowels, constants, special characters and integers in a string
            //stringFunctions.CountCharacters("This is @ &pecial $tr1ng.", out int vowels, out int consonants, out int integers, out int specialChars);
            //Console.WriteLine("No. of constants: "+consonants);
            //Console.WriteLine("No. of vowels: " + vowels);
            //Console.WriteLine("No. of integers: " + integers);
            //Console.WriteLine("No. of special characters: " + specialChars);
        }
    }
}