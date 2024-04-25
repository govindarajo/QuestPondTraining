using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal class Director
    {
        public clsReport MakeReport(ReportBuilder obj)
        {
            obj.SetReportType();
            obj.SetHeader();
            obj.SetFooter();
            return obj.GetReport();
        }
    }
}
