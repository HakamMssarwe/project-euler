using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Largest_prime_factor
{
    class Program
    {
        static void Main(string[] args)
        {

            long num = 600851475143;
            long sqrt;
            sqrt = (long)Math.Round(Math.Sqrt(num));

            while ((Math.Pow(sqrt, 2)) - num < 0)
            {
                sqrt++;

            }

            long N = (long)Math.Pow(sqrt, 2);

            while ((Math.Sqrt(N - num) - (int)Math.Sqrt(N - num) != 0))
            {
                sqrt++;
                N = (long)Math.Pow(sqrt, 2);
            }

            long sqrtNoDecimal = (long)Math.Sqrt(N - num);


            long FirstMulti = sqrt + sqrtNoDecimal;
            long SecondMulti = sqrt - sqrtNoDecimal;
            bool checkPrime = true, primeFound = false;


            long PrimeNumber1 = 0;
            long PrimeNumber2 = 0;


            while (checkPrime == true)
            {
                checkPrime = false; //<-- Set to false to begin the check

                for (int i = 2; i < FirstMulti; i++)
                {
                    if (FirstMulti % i == 0)
                    {
                        checkPrime = true;
                        break;
                    }

                }

                if (checkPrime == false)
                {
                    PrimeNumber1 = FirstMulti;
                    primeFound = true;
                }

                checkPrime = false; //<-- Set to false to begin the check


                for (int i = 2; i < SecondMulti; i++)
                {
                    if (SecondMulti % i == 0)
                    {
                        checkPrime = true;
                        break;
                    }
                }

                if (checkPrime == false)
                {
                    PrimeNumber2 = SecondMulti;
                    primeFound = true;
                }


                if (primeFound == true)
                {
                    checkPrime = false;
                }


                if (checkPrime == true)
                {
                    sqrt++;
                    N = (long)Math.Pow(sqrt, 2);
                    while ((Math.Sqrt(N - num) - (int)Math.Sqrt(N - num) != 0))
                    {
                        sqrt++;
                        N = (long)Math.Pow(sqrt, 2);
                    }

                    sqrtNoDecimal = (long)Math.Sqrt(N - num);

                    FirstMulti = sqrt + sqrtNoDecimal;
                    SecondMulti = sqrt - sqrtNoDecimal;
                }
            }

            long MaxPrime = Math.Max(PrimeNumber1, PrimeNumber2);

            Console.WriteLine(MaxPrime);











        }
    }
}

