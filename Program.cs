using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisionComputation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation program on Master Branch");
            LineComparision firstLine = new LineComparision();
            LineComparision secondLine = new LineComparision();
            firstLine.PointValues();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line: " + firstLineLength);
            secondLine.PointValues();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line: " + secondLineLength);
            if (firstLineLength.CompareTo(secondLineLength) > 0)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (firstLineLength.CompareTo(secondLineLength) == 0)

            {
                Console.WriteLine("Lines are equal");
            }
            else
            {
                Console.WriteLine("Line2 is greater than Line1");
            }
            Console.ReadLine();

        }
    }
}
