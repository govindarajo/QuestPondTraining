using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypeLearning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = null;
            string str2 = "str2";
            string str3 = null;
            string str4 = null;

        string str5 = null;

            string final = str4 ?? str5 ?? str3 ?? str2 ?? str1;

            Console.WriteLine(final);

            Console.ReadLine();

        }
    }
}
