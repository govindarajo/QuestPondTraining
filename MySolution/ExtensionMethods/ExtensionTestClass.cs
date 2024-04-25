using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    internal static class ExtensionTestClass
    {
        internal static string MyMethod(this string obj)
        {
            return obj + "GovindMethod";
        }
    }
}
