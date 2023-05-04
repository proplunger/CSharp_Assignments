using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignmentdll;

namespace AssignmentdllConsume
{
    public static class ExtendedNumericFunctions
    {
        public static List<int> EvenRange(this NumericFunctions numFunc, int l,int u) { 
        List<int> result = new List<int>();
            for (int i = l; i < u; i++) {
                if (i%2==0) { result.Add(i); }
            }
            return result;
        }

        public static List<int> OddRange(this NumericFunctions numFunc, int l, int u)
        {
            List<int> result = new List<int>();
            for (int i = l; i < u; i++)
            {
                if (i % 2 != 0) { result.Add(i); }
            }
            return result;
        }

        public static List<int> PrimeRange(this NumericFunctions numFunc, int l, int u)
        {
            NumericFunctions nm = new NumericFunctions();
            List<int> result = new List<int>();
            for (int i = l; i < u; i++)
            {
                if (nm.CheckPrime(i)) {
                result.Add(i);
                }
            }
            return result;
        }

        public static string ReverseNum(this NumericFunctions numFunc, int num)
        {
            string s1 = num.ToString();
            char[] charArray = s1.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);

        }

        public static string NumTable(this NumericFunctions numFunc,int num) {
            StringBuilder str = new StringBuilder();
            for (int i = 1; i <= 10; i++) {
                str.Append($"{num} * {i} = {num*i}\n");
            }
            return str.ToString().Trim();
        }

        public static string TableRange(this NumericFunctions numFunc, int l, int u) {
            NumericFunctions numericFunctions = new NumericFunctions();
            StringBuilder sb = new StringBuilder();
            for (int i = l; i <= u; i++) {
                sb.Append($"Table of {i}\n");
                sb.Append(numericFunctions.NumTable(i));
            }
            return sb.ToString().Trim();
        }

        public static string TableRangeInRange(this NumericFunctions numFunc, int l, int u, int tl, int tu) { 
        StringBuilder sb = new StringBuilder();
            for (int i = l;i<=u;i++) {
                sb.Append($"Table of {i}\n");
                for (int j = tl;j<=tu;j++) {
                    sb.Append($"{i} * {j} = {i*j}\n");
                }
            
            }
            return sb.ToString().Trim();
        }
    }
}
