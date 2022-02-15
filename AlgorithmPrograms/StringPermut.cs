using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class StringPermut
    {
        public void Permutation(String str, int i, int j)
        {
            if (i == j)
                Console.WriteLine("Your String is "+ str);
            else
            {
                for (int i2 = 1; i2 <= j; i2++)
                {
                    str = Swap(str, i, i2);
                    Permutation(str, i + 1, j);
                    str = Swap(str, i, i2);
                }
            }
        }
        public static String Swap(String a, int m, int n)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[m];
            charArray[m] = charArray[n];
            charArray[n] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
