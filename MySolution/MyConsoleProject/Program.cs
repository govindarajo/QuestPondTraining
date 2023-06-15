using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Runtime.Remoting.Lifetime;

namespace MyConsoleProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get a type

            // Get the reference of an assembly

            var myAssembly = Assembly.LoadFrom(@"D:\QuestPond\MySolution\SomeReflectionLibrary\bin\Release\SomeReflectionLibrary.dll");

            var type = myAssembly.GetType("SomeReflectionLibrary.Class1");

           var myObjInstance =  Activator.CreateInstance(type);

            var paramType = myObjInstance.GetType();

            //foreach (var item in paramType.GetMembers())
            //{
            //    Console.WriteLine(item.Name);
            //}

            paramType.InvokeMember("Method1", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod |BindingFlags.Instance, null, myObjInstance, null);
            Console.Read();
            //Console.WriteLine("Started blasting");

            //for (double i = 0; i < 100000000; i++)
            //{
            //    var cust = new Customer();
            //    cust.Name = "Teat";
            //}
            //Console.Read();
        }
        public class Customer
        {
            public string Name { get; set; }
        }
    }
}
