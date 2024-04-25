using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unity;
using Unity.Injection;

namespace DependencyInjection
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var customer = Factory.GetCustomer();
            //var customer = new Customer(new Oracle());
            customer.CustomerName = "TestName";
            customer.Add();

           
        }
    }

    public class Factory
    {
        public static Customer GetCustomer()
        {
            IUnityContainer container = new UnityContainer();

            
            container.RegisterType<IDal, Oracle>("Oracle");
            container.RegisterType<IDal, SqlServer>("Sql");
            container.RegisterType<Customer>("CustOra", new InjectionConstructor
                (new ResolvedParameter<IDal>("Oracle")));

            container.RegisterType<Customer>("CustSql", new InjectionConstructor
                (new ResolvedParameter<IDal>("Sql")));


            return container.Resolve<Customer>("CustSql");

        }
    }

    public class Customer
    {
        private IDal dal = new SqlServer();
        public string CustomerName { get; set; }

        public Customer(IDal oDal)
        {
            dal = oDal;
        }
        public Customer()
        {
            
        }
        public void Add()
        {
            dal.Add();
        }
    }

    public interface IDal
    {
        void Add();
    }
    public class SqlServer : IDal
    {
        public void Add()
        {
            Console.WriteLine("Added the customer data in sql server");
            //throw new NotImplementedException();
        }
    }

    public class Oracle : IDal
    {
        public void Add()
        {
            Console.WriteLine("Added the customer data in Oracle server");
            //throw new NotImplementedException();
        }
    }
}
