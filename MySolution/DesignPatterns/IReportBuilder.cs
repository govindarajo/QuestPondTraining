using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns
{
    internal abstract class ReportBuilder
    {
        protected clsReport objReport;
        public ReportBuilder() 
        {
            objReport = new clsReport();
        }

        public abstract void SetReportType();

        public abstract void SetHeader();
        public abstract void SetFooter();

        public clsReport GetReport()
        {
            return objReport;
        }
    }

    class ReportPdf : ReportBuilder
    {
        
        public override void SetFooter()
        {
            objReport.SetReportFooter("Pdf Footer 1");
        }

        public override void SetHeader()
        {
            objReport.SetReportHeader("Pdf Header 1");
        }

        public override void SetReportType()
        {
            objReport.reportType = "PDF";
        }
    }

    class ReportExcel : ReportBuilder
    {
        public override void SetFooter()
        {
            objReport.SetReportFooter("Excel Footer 1");
        }

        public override void SetHeader()
        {
            objReport.SetReportHeader("Excel Header 1");
        }

        public override void SetReportType()
        {
            objReport.reportType = "Excel";
        }
    }
}
