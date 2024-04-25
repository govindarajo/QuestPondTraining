using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeywordsLearning
{
    internal class Program
    {
        static List<int> myList = new List<int>();
        static void Main(string[] args)
        {
            //foreach (var val in FilterList())
            //{
            //    Console.WriteLine(val);
            //}


            //Yield Keyword 
            //foreach (var val in RunningTotal())
            //{
            //    Console.WriteLine(val);
            //}


            //Indexer keyword
            var indexerTest = new IndexerTest();
            
            indexerTest["City"] = new Address() { City = "Covai", Location = "TamilNadu", PhoneNumber = "80080", Pincode = 459 };

            var finalAdd = indexerTest["Covai"];

            Console.ReadLine();
        }
        static IEnumerable<int> RunningTotal() //Statefull iteration - This will hold the total value as well as the iteration value
        {
            FillMyList();
            int runningTotal = 0;
            foreach (var val in myList)
            {
                runningTotal += val;
                yield return runningTotal;
            }
        }
        static IEnumerable<int> FilterList()  //Custom Iteration
        {
            FillMyList();
            foreach (var i in myList)
            {
                if(i>3)
                yield return i;
            }
        }

        private static void FillMyList()
        {
            myList.Add(1);
            myList.Add(2);  
            myList.Add(3);
            myList.Add(4);
            myList.Add(5);
            myList.Add(6);

            
        }
    }

    internal class IndexerTest
    {
        private List<Address> addressList = new List<Address>();

        public Address this[string City]
        {
            set { addressList.Add(value); }
            get
            {
                foreach (var add in addressList)
                {
                    if (add.City == City)
                        return add;
                }
                return null;
            }
        }
    }

    internal class Address
    {
        public string Location { get; set; }
        public string City { get; set; }
        public string PhoneNumber { get; set; }
        public int Pincode { get; set; }
    }
}


