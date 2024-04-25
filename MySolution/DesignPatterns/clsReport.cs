using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class clsReport
    {
        public string reportType;
        private ArrayList reportHeader = new ArrayList();
        private ArrayList reportFooter = new ArrayList();

        public void SetReportHeader(string strData)
        {
            reportHeader.Add(strData);
        }

        public void SetReportFooter(string strData)
        {
            reportFooter.Add(strData);
        }

        public void DisplayReport()
        {
            Console.WriteLine("---------");
            Console.WriteLine("Report Type is "+ reportType);
            foreach(var item in reportHeader)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("------------------------");
            foreach (var item in reportFooter)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("--------------------------");
        }
    }
}
