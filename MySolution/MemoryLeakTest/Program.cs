using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using Timer = System.Threading.Timer;

namespace MemoryLeakTest
{
    internal class Program
    {
        static Action<string> action = (name) =>
        {
            Console.WriteLine("Action delagate called with name " + name);// resource.resource.UseResource();
        };

        static void Main(string[] args)
        {
            //Publisher publisher = new Publisher();
            //Subscriber subs = new Subscriber(publisher);

            //SomeClass obj = StaticMemoryLeakClass.GetObject();
           // SomeOperation(null);
            //ResouceManagerTest.resource.UseResource();
            ResouceManagerTest resource = new ResouceManagerTest();
            //resource.resource.UseResource();
            //MessageBox.Show("Main method closed");

            Console.WriteLine("Main method is closed");
            //publisher.DoSomething();
            //SomeOperation(publisher);
            TestAction((a) => Console.WriteLine("In param code")); 
           
            action.Invoke("Govind");
            Console.ReadLine();
        }

        private static void TestAction(Action<string> action)
        {
            action.Invoke("From another method");
        }

        private static void SomeOperation(Publisher publisher)
        {
            for (int i= 0; i < 10; i++)
            {
               // var obj = ResouceManagerTest.CreateObject();
                //obj.UseResource();
                ResouceManagerTest resource = new ResouceManagerTest();
                resource.resource.UseResource();

                ResouceManagerTest.DisposeResource();
            }

            //ResouceManagerTest resource = new ResouceManagerTest();
            //resource.resource.UseResource();
            //var subscriber = new Subscriber(publisher);

            //throw new NotImplementedException();
        }
    }

    class Publisher
    {
        public event EventHandler MyEvent;

        public void DoSomething()
        {
            MyEvent?.Invoke(this, EventArgs.Empty);
        }
    }
    class Subscriber : IDisposable
    {
        private Publisher _publisher;
        public Subscriber(Publisher publisher) 
        {
            _publisher = publisher;

            _publisher.MyEvent += Subscribe;
        }

        public void Dispose()
        {
            _publisher.MyEvent -= Subscribe;
            //throw new NotImplementedException();
        }

        private void Subscribe(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

    }

    class MyClass
    {
        public MyClass()
        {
            var manualResetEvent = new ManualResetEvent(false);
            Timer timer = new Timer(HandleTick);
            timer.Change(TimeSpan.FromSeconds(5),TimeSpan.FromSeconds(5));

            var leakyThread = new Thread(() =>
            {
                while(!manualResetEvent.WaitOne())
                {
                    Thread.Sleep(1000);
                }
            });

            leakyThread.Start();

            Thread.Sleep(5000);

            manualResetEvent.Set();
            leakyThread.Join();
        }

        private void HandleTick(object state)
        {

        }
    }
}
