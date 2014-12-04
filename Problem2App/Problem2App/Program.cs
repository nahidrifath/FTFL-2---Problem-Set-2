using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2App
{
    class Program
    {
        static void Main(string[] args)
        {
            Int64 sum = 0;
            Int64 num1 = 0;
            Int64 num2 = 1;
            Int64 result = 0;

            while (result<4000000)
            {
                result = num1 + num2;
                num1 = num2;
                num2 = result;
                if (num2 % 2 == 0)
                {
                    sum += num2;
                    Console.WriteLine(num2);
                }
                
            }

            Console.WriteLine("Sum is: "+sum);
            Console.ReadKey();

        }
    }
}
