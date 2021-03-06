using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicing
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int easy, peasy = 1;

            for (int i = 2; i < 4000000;) //<because the question asked for numbers until 4 Million 
            {

                easy = i;
                i = peasy + i;
                peasy = easy;

                if (i%2 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum+2); //<-- +2 because the "i" doesn't count that cause in the first loop it will be 3.

           



        }
    }
}
