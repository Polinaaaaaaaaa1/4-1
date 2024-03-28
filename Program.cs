using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_1
{
    using System;

    internal class Program
    {
        static void Main(string[] args)
        {
            OneDimensionalArray<int> intArray = new OneDimensionalArray<int>();
            for(int i = 0; i < 10; i ++)
            {
                intArray.Add(i);
            }

            Console.WriteLine("array before sorting");
            intArray.ForEach(Console.WriteLine);

            intArray.Sort();
            Console.WriteLine(intArray.Any(x => x % 2 == 0));

            Console.WriteLine("\nsorted array");
            intArray.ForEach(Console.WriteLine);

            int min = intArray.GetElementAt(0);
            int max = intArray.GetElementAt(intArray.Count() - 1);
            Console.WriteLine($"\nmin {min}");
            Console.WriteLine($"max {max}");

            OneDimensionalArray<double> doubleArray = new OneDimensionalArray<double>();

            doubleArray.Add(3.5);
            doubleArray.Add(1.2);
            doubleArray.Add(6.8);

            Console.WriteLine("\n\narray before sorting");
            doubleArray.ForEach(Console.WriteLine);

            doubleArray.Sort();
            Console.WriteLine("\narray after sorting");
            doubleArray.ForEach(Console.WriteLine);

            double minDouble = doubleArray.GetElementAt(0);
            double maxDouble = doubleArray.GetElementAt(doubleArray.Count() - 1);
            Console.WriteLine($"\nmin: {minDouble}");
            Console.WriteLine($"max {maxDouble}");
        }
    }

}
