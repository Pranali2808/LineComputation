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
            LineComparision lineComparison = new LineComparision();
            lineComparison.PointValues();
            double lineLength = lineComparison.GetLength();
            Console.WriteLine("Length of first Line according to points is= " + lineLength);
            Console.ReadLine();
        }
    }
}
