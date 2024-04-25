using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Delegate  //Delegate is a type safe function pointer
{
    public delegate bool PromoteLogic(Employee employee);

    internal class Program
    {
        static void Main(string[] args)
        {
            //HelloDelegate del = new HelloDelegate(Hello);
            //del("Hello world!");
            //var emps = new List<Employee>();
            //emps.Add(new Employee() { Name = "Govind", Experience = 10, age = 35 });
            //emps.Add(new Employee() { Name = "Raj", Experience = 15, age = 35 });
            //emps.Add(new Employee() { Name = "Venkat", Experience = 9, age = 35 });
            //emps.Add(new Employee() { Name = "Muthu", Experience = 5, age = 35 });
            //emps.Add(new Employee() { Name = "TS", Experience = 8, age = 35 });

            //Employee.PromoteEmployee(emps,new PromoteLogic(PromoteLogicEmp));

            // Employee.PromoteEmployee(delegate (Employee emp) { emp.Experience >= 5 });
            //  Employee.PromoteEmployee(emps,emp=>emp.Experience>8);

            //var empp = emps.Find(delegate(Employee emp) { return emp.Experience  == 8; });

            //Func<int, int, string> funcObj = (firstNumber, secondNumber) => "Sum = " + (firstNumber + secondNumber).ToString();

            //var sum = funcObj(10, 20);
            //Console.ReadLine();

            #region InterViewDelegate
            var interviewDelegate = new InterviewDelegate();
            interviewDelegate.DelegateMethodToCall();
            #endregion
        }

        public static bool PromoteLogicEmp(Employee emp)
        {
            SemaphoreSlim sl = new SemaphoreSlim(2, 2);
            sl.Wait();

            sl.Release();

            var m = new Mutex();
            m.WaitOne();
            m.ReleaseMutex();
            if (emp.Experience > 10)
                return true;

            return false;
        }

        
    }
    public class Employee
    {
        public string Name { get; set; }
        public int Experience { get; set; }
        public int age { get; set; }
            public Employee() { }   
        public Employee(string name) { }

        public static void PromoteEmployee(List<Employee> employee,PromoteLogic isEligible)
        {
            foreach (var emp in employee)
            {
                if(isEligible(emp))
                {
                    Console.WriteLine(emp.Name + " is Promoted");
                }
            }

        }
    }
    public class InterviewDelegate
    {
        delegate void Printer();
        public void DelegateMethodToCall()
        {
            List<Printer> printerList = new List<Printer>();
            int i = 0;
            for (; i < 10; i++)
            {
                printerList.Add(delegate { Console.WriteLine(i); });
            }

            foreach (var p in printerList)
            {
                p();
            }
        }
    }
        
}
   

