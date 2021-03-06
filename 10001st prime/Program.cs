using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001st_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            int i = 1;
            long primenumber = 0;
            bool notprime = false;

            while (counter != 10001)
            {
                if (i % 2 != 0)
                {
                    notprime = false;

                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            notprime = true;
                            break;
                        }
                    }

                    if (notprime == false)
                    {
                        counter++;
                        if (counter == 10001)
                            primenumber = i;
                    }

                    i++;
                }



                else
                    i++;

            }

            Console.WriteLine(primenumber);



        }
    }
}
