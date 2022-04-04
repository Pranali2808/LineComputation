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
<<<<<<< HEAD
            Console.WriteLine("Welcome to Line Comparison Computation Program");

=======
>>>>>>> UC3_LenghthSmallGreate
            Console.WriteLine("Welcome to Line Comparison Computation program on Master Branch");
            LineComparision firstLine = new LineComparision();
            LineComparision secondLine = new LineComparision();
            firstLine.PointValues();
            double firstLineLength = firstLine.GetLength();
            Console.WriteLine("Length of first Line: " + firstLineLength);
            secondLine.PointValues();
            double secondLineLength = secondLine.GetLength();
            Console.WriteLine("Length of Second Line: " + secondLineLength);
<<<<<<< HEAD

            if (firstLineLength == secondLineLength)
            {
=======
            if (firstLineLength > secondLineLength)
            {
                Console.WriteLine("Line1 is greater than Line2");
            }
            else if (firstLineLength == secondLineLength)
            {
>>>>>>> UC3_LenghthSmallGreate
                Console.WriteLine("Lines are equal");
            }
            else
            {
<<<<<<< HEAD
                Console.WriteLine("Lines are not equal");
=======
                Console.WriteLine("Line2 is greater than Line1");
>>>>>>> UC3_LenghthSmallGreate
            }
            Console.ReadLine();
        }
    }
}
