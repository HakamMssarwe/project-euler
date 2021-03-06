using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summation_of_primes
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 2000000;
            long sum = 0;

            for (int i = 2; i < limit; i++)
            {
                if (PrimeCheck(i))
                {
                    sum += i;
                }

            }
            Console.WriteLine(sum);

        }

        static bool PrimeCheck (int num)
        {
            if (num == 2)
                return true;
            else if (num % 2 == 0)
                return false;

            for (int i = 3; i <= Math.Floor(Math.Sqrt(num)); i++)
            {
                if (num % i == 0)
                    return false;

            }
            return true;

        }


    }
}
