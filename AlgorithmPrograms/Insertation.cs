using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class Insertation
    {
        public void InsertSort(String[] arr)
        {
            int i, j;
            for(i=1;i<arr.Length;i++)
            {
                String value = arr[i];
                j = i-1;
                while((j>=0) && (arr[j].CompareTo(value)>0))
                {
                    arr[j+1]=arr[j];
                    j--;
                }
                arr[j + 1]=value;
            }
        }
    }
}
