using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintPrime
{
    class Program
    {
        public void findPrime(int x,int y)
        {
            int i, j, flag;
            
            for (i = x; i <= y; i++)
            {
                if (i == 1 || i == 0)
                    continue;
                flag = 1;

                for (j = 2; j <= i / 2; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }
                if (flag == 1)
                    Console.WriteLine(i+" Suyash Kala");
            }
        }
        
    static void Main(string[] args)
        {
            int a,b;
        Console.WriteLine("Enter lower bound of " +
                          "the interval: ");
        a = int.Parse(Console.ReadLine());

        Console.WriteLine("\nEnter upper bound " +
                          "of the interval: ");
            b = int.Parse(Console.ReadLine());

            new Program().findPrime(a, b);
            Console.ReadKey();
    }
    }
}
