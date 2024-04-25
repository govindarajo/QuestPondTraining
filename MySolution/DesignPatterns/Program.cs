namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            clsReport objReport;

            var objDirector = new Director();

            var objPdfReport = new ReportPdf();
            objReport = objDirector.MakeReport(objPdfReport);
            objReport.DisplayReport();

            var objExcelReport = new ReportExcel();
            objReport = objDirector.MakeReport(objExcelReport);
            objReport.DisplayReport();
        }
    }
}
