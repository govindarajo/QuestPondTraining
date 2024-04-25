using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9,10 };

            var ress = numbers.Where(num => method1(num));

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            
        }

        static bool method1(int x)
        {
            if (x % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
