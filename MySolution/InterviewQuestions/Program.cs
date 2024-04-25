using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    struct TestStruct
    {
        public int a;
        public int b;
        //public int c;

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var s = new TestStruct();
            //Console.WriteLine(s.sum(2, 5));
            s.a = 10;
            s.b = 30;
            
            var t = s;

            t.a = 40;
            t.b = 60;

           // Console.WriteLine("Address of s object is = {0}  and Address of t is = {1} ",&s,&t);
            //Swap(30, 35);
        }

        static void SplitAndSum()
        {
            int a = 148;

            int n1 = a / 100;
            int n2 = (a / 10) % 10;
            int n3 = a % 10;

            Console.WriteLine(n1 + n2 + n3);
        }
        static void Swap(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("a =" + a + " b = " + b);
        }
    }
}
