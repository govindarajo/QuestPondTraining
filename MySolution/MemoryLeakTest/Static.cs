using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoryLeakTest
{
    internal class StaticMemoryLeakClass
    {
        private static SomeClass staticObj = new SomeClass();

        public static SomeClass GetObject()
        {
            return staticObj;
        }
    }
    internal class SomeClass
    {
        public int MyProperty { get; set; }
    }

    internal class Resource
    {
        public void UseResource()
        {
            //MessageBox.Show("Use resource method of Resource class is called");
            Console.WriteLine("Use resource method of Resource class is called");
        }

        //~Resource()
        //{
        //    Console.WriteLine("Resource is garbage collected");
        //}
    }

    internal class ResouceManagerTest
    {
        public Resource resource = new Resource();
        //public static Resource resource = new Resource();

        //public static Resource CreateObject()
        //{
        //    //if (resource == null)
        //    //     resource = new Resource();

        //    //return resource;
        //}
        public static void DisposeResource()
        {
            Console.WriteLine("Disposed resource manager");
            //resource = null;
        }

        //~ResouceManagerTest()
        //{
        //    Console.WriteLine("Resource manager destructor called");
        //}
    }
}
