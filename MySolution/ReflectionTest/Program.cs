using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace ReflectionTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var assembly = Assembly.LoadFrom("D:\\QuestPond\\MySolution\\ReflectionTestLib\\bin\\Debug\\ReflectionTestLib.dll");

            var type = assembly.GetType("ReflectionTestLib.Class1");

            var instance = Activator.CreateInstance(type);

            var paramType = instance.GetType();

            foreach(var param in  paramType.GetMembers())
            {
                Console.WriteLine(param.Name);
            }

            type.InvokeMember("PrivateMethod",BindingFlags.Public 
                        | BindingFlags.NonPublic | BindingFlags.InvokeMethod |
                         BindingFlags.Instance,null,instance,null);
        }
    }
}
