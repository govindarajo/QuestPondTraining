using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection;
using System.Runtime.Remoting.Lifetime;
using System.Threading;
//using System.Threading.Tasks;

namespace MyConsoleProject
{
    internal class Program
    {
        //static Mutex mutex = new Mutex(true,"MyTestApp");
        static Semaphore semaphr = new Semaphore(3,3, "MyTestApp");
        //static AutoResetEvent obj = new AutoResetEvent(false);
        static ManualResetEvent obj = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            Parallel.For(0, 1000000,x=> RunMillionIteration());
            Task t = new Task(Function1);
           // ThreadPool.QueueUserWorkItem(Function1);
            //var customer = new Customer();
            //var thread1 = new Thread(customer.FunctionForThread);
            //thread1.Start();
            //Console.WriteLine("Main thread Waiting");
            //Console.ReadLine();
            //obj.Set();
            //Console.WriteLine("Main thread waiting for 2nd");

            //Console.ReadLine();
            //obj.Set();
            //Console.WriteLine("Main thread exited");
            //int i = 1;
            //if(!semaphr.WaitOne(0,false))
            //{
            //    Console.WriteLine("One instance in already acquired");
            //}
            //else
            //{

            //    Console.WriteLine("instance " + i++ +" is created");
            //}
            //Console.ReadLine();
            //Get a type
            // var customer = new Customer();

            // var thread1 = new Thread(customer.FunctionForThread);
            // //var thread2 = new Thread(customer.Function2ForThread);
            // thread1.IsBackground = true;
            // thread1.Start();
            // //thread2.Start();

            // Console.WriteLine("Main thread existed");
            //// ICustemer1 cust1 = new Customer();

            // var instance1=  SingletonTest.GetInstance();
            // var instance2 = SingletonTest.GetInstance();

            // customer.calculateBill();
            // // Get the reference of an assembly

            // var myAssembly = Assembly.LoadFrom(@"D:\QuestPond\MySolution\SomeReflectionLibrary\bin\Release\SomeReflectionLibrary.dll");

            // var type = myAssembly.GetType("SomeReflectionLibrary.Class1");

            //var myObjInstance =  Activator.CreateInstance(type);

            // var paramType = myObjInstance.GetType();

            //foreach (var item in paramType.GetMembers())
            //{
            //    Console.WriteLine(item.Name);
            //}

            //paramType.InvokeMember("Method1", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod |BindingFlags.Instance, null, myObjInstance, null);
            //Console.Read();
            ////Console.WriteLine("Started blasting");

            //for (double i = 0; i < 100000000; i++)
            //{
            //    var cust = new Customer();
            //    cust.Name = "Teat";
            //}
            //Console.Read();
        }

        private static void RunMillionIteration()
        {
            for(int i = 0; i < 100000; i++)
            {

            }
        }
        public static void Function1()
        {
            Console.WriteLine("TEt");
        }
        public class Customer : ICustomer,ICustemer1
        {
            public string Name { get; set; }

            public int calculateBill()
            {
                throw new NotImplementedException();
            }

            public int CalculateBill1()
            {
                throw new NotImplementedException();
            }
            public void FunctionForThread()
            {
                Console.WriteLine("Thread 1 Entered");
                obj.WaitOne();
                //Console.ReadLine();
                Console.WriteLine("Thread 1 Exited");

                 Console.WriteLine("Thread 2 Entered");
                obj.WaitOne();
                //Console.ReadLine();
                Console.WriteLine("Thread 2 Exited");
                //for(int i=0;i<10;i++)
                //{
                //    Console.WriteLine("Function 1 Executed");
                //    Thread.Sleep(4000);
                //}
            }
            public void Function2ForThread()
            {
                //for (int i = 0; i < 10; i++)
                //{
                //    Console.WriteLine("Function 2 Executed");
                //    Thread.Sleep(4000);
                //}
            }
        }

        public interface ICustomer
        {
            int calculateBill();
        }
        public interface ICustemer1:ICustomer
        {
            int CalculateBill1();
        }

        public class SingletonTest
        {
            private static SingletonTest instance;
            private SingletonTest()
            {

            }

            public static SingletonTest GetInstance()
            {
                if(SingletonTest.instance==null)
                    SingletonTest.instance = new SingletonTest();
                return SingletonTest.instance;
            }
        }
     }
}
