using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class BubblesSort
    {
        public void Bubbles(int[] arr)
        {
            int num = arr.Length;
            for (int i = 0; i < num-1; i++)
            {
                for (int j = 0; j<num-i-1;j++)
                {
                    if (arr[j]>arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j+1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
        public void Display(int[] arr)
        {
            int num = arr.Length;
            for (int i =0; i<num;i++)
            {
                Console.WriteLine(arr[i] + " ");
            }
            Console.WriteLine("  ");
        }

    }
}
