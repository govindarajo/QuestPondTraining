using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutVsRef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int val = 10;

            Manipulate(out val);

            Console.WriteLine(val);

        }

        private static void Manipulate(out int val)
        {
            //any data to the caller from callee is discarded.

            val = 10;

            val = val + 10;
        }
    }
}
