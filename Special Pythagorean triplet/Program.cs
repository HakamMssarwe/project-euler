using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Special_Pythagorean_triplet
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 1000;

            for (int a = 3; a < limit; a++)
            {
                for (int b = a+1; b < limit; b++)
                {
                    double c = Math.Pow(a,2) + Math.Pow(b, 2);
                    c = Math.Sqrt(c);

                    if (a+b+c == limit)
                    {
                        Console.WriteLine($"{a*b*c}");
                        return;
                    }

                }

            }




        }
    }
}
