using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smallest_multiple
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = false;

            int i = 1;
            int counter = 0;

            int DivideByAll = 20;

            while (stop == false)
            {

                for (int j = 1; j <= DivideByAll; j++)
                {
                    if (i % j == 0)
                    {
                        counter++;
                    }

                    else
                        break;
                }

                if (counter == DivideByAll)
                {
                    Console.WriteLine(i);
                    stop = true;
                }

                counter = 0;
                i++;
                
            }




        }
    }
}
