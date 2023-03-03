using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;

namespace Primefactors
{
    public class primeFactors
    {
        public static void factors()
        {
            Console.WriteLine("Enter the prime factors: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=input;i++)
            {
                        Console.WriteLine(i);

                for (int j = 1; j <= i; j++)
                {
                    int count = 0;
                    if (i%j==0)
                    {
                        count++;
                    }
                    if (count == 2)
                    {
                    }
                }
            }
        }
    }
}
