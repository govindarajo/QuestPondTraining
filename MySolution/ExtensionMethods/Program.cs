using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s = "Called method is ";
            
            Console.WriteLine(s.MyMethod());


            string str1 = null;
            string str2 = null;
            string str3 = null;

            string str4 = null;
            //string str5 = "Final";

            var final = str1 ?? str2 ?? str3 ?? str4;

            Console.WriteLine(final);
        }
    }
}
