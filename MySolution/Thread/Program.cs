using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
   
    internal class Program
    {
        
        static void Main(string[] args)
        {
            //TestStruct ts = new TestStruct();
            //Console.WriteLine(ts.sum(2, 5));
            //  ThreadPool.QueueUserWorkItem(new WaitCallback(method1));
            // Parallel.For(0, 1000, x => method1());
            //Task.Run(new Action(method1));
            //method2();
            //Console.WriteLine("Main Thread");
            //Console.ReadLine();
            //var task = new Task(method1);

            //SemaphoreSlim s = new SemaphoreSlim(1);
            //s.Wait();

            //s.Release();

            #region Parrallel exceution
            //var thread1 = new Thread(ThreadMethod1);

            //var thread2 = new Thread(ThreadMethod2);

            //thread1.Start();
            //thread2.Start();
            #endregion

            #region Background thread test
            //var thread1 = new Thread(BackgroundThreadTest);
            //thread1.Name = "BackgroundTstThread";
            //thread1.Start();

            //thread1.IsBackground = true;
            //Console.WriteLine("Main method ended");
            #endregion

            #region AsyncAndAwait
            AsyncAndAwait();
            Console.WriteLine("Main thread Ends");
            Console.ReadLine();
            #endregion
        }
        public static void method1()
        {
            Console.WriteLine("Pool Called");
        }
        public static async void method2()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread");
        }
        public static void LongTask()
        {
            Thread.Sleep(5000);
        }

        public static void ThreadMethod1()
        {
            for (int i = 0; i < 10; i++)
            {
                //MessageBox.Show("Mehtod 1");
                Console.WriteLine("Method 1 and value is = " + i);
                Thread.Sleep(1000);
            }
        }
        public static void ThreadMethod2()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Method 2 and value is = " + i);
                Thread.Sleep(1000);
            }
        }

        public static void BackgroundThreadTest()
        {
            Console.WriteLine("Background thread method called");
            Console.ReadLine();
            Console.WriteLine("background method thread ended");
        }

        public static async void AsyncAndAwait()
        {
            await Task.Run(AsyncMethod1);
            Console.WriteLine("Async Await Method finished");
        }

        private static void  AsyncMethod1()
        {
            Thread.Sleep(20000);
        }
    }
}
