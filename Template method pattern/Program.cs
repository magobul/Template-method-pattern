using Template_method_pattern;
class Program
{
    static void Main(string[] args)
    {
        ReportGenerator studentReport = new StudentReportGenerator();
        studentReport.GenerateReport();

        Console.WriteLine();

        ReportGenerator courseReport = new CourseReportGenerator();
        courseReport.GenerateReport();
    }
}
