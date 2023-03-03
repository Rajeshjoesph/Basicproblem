using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber
{
    public class harmonicNumber
    {
        public static void harmonic()
        {
            double sum = 0.0;
            Console.WriteLine("Enter n noumber of value: ");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= input; i++)
            {
                Console.Write("1/{0} + ",i);
                sum += 1 / (float)i;
            }
            Console.WriteLine("\n Nth Harmonic Value: " + sum);

        }
    }
}
