using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem6App
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumOfSquare = 0;
            double squareOfSum = 0;
            int sumOfHundredNaturalNumbers = 0;
            double difference = 0;

            for (int i = 1; i <= 10; i++)
            {
                sumOfSquare += Math.Pow(i, 2);
                sumOfHundredNaturalNumbers += i;
            }
            squareOfSum = Math.Pow(sumOfHundredNaturalNumbers, 2);
            difference = squareOfSum - sumOfSquare;
            Console.WriteLine(difference);
            Console.ReadKey();
        }
    }
}
