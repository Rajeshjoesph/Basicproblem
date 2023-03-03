using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    public class powerOfTwo
    {
        public static void number()
        {
            Console.WriteLine("Enter the rangr of value:");
            int input = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=input;i++)
            {
                int tables = i * 2;
                Console.WriteLine(i+"*"+"2"+ "="+ tables);
            }
        }
    }
}
