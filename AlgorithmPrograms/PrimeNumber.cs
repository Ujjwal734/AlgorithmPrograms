using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms
{
    public class PrimeNumber
    {
        public void Prime(int m, int n)
        {
            int count = 0;
            for (int i = m; i < n; i++)
            {
                count = 0;
                if (i > m)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }
                    }
                    if (count == 0)
                    {
                        Console.Write(i + "  ");
                    }
                }
            }
        }
    }
}
