using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class StringBinarys
    {
        public  int Search(String[] arr, String x)
        {
            int m = 0, r = arr.Length - 1;
            while(m <= r)
            {
                int i = m + (r - m) / 2;
                int result = x.CompareTo(arr[i]);
                if (result == 0)
                    return i;
                if (result > 0)
                    m = i + m;
                else
                    r = i - m;
            }
            return -1;
        }
        public void Display()
        {

        }
    }
}
