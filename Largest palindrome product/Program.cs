using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_palindrome_product
{
    class Program
    {
        static void Main(string[] args)
        {
            int largestPalindom = 0;

            for (int i = 100; i < 1000; i++)
            {
                for (int j = 100; j < 1000; j++)
                {
                    int num = i * j;
                    int res = 0;
                    int tempnum = num;
                    while (tempnum != 0) //<-- revert the number and check if it changes, if it goes then it's not palindrom. else it is.
                    {
                        res *= 10;
                        res += tempnum % 10;
                        tempnum /= 10;
                    }

                    if (res == num)
                    {
                        largestPalindom = Math.Max(res, largestPalindom);
                    }

                }


            }

            Console.WriteLine(largestPalindom);


        }
    }
}
