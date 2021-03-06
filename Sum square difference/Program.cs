using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_square_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            long SquareSum = 0;


            for (int i = 1; i <= 100; i++)
            {
                SquareSum += i;
            }
            SquareSum *= SquareSum; //<--- To the power of 2.


            long sumOfSquare = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquare += (i * i);
            }

            long difference = SquareSum - sumOfSquare;

            Console.WriteLine(difference);

        }
    }
}
