internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}

//Before SRP
//public class Report
//{
//    public string GetReportData()
//    {
//        // Code to fetch report data
//        return "Report Data";
//    }

//    public void PrintReport(string reportData)
//    {
//        // Code to print the report
//        Console.WriteLine("Printing Report: " + reportData);
//    }
//}

//After SRP
public class Report
{
    public string GetReportData()
    {
        // Code to fetch report data
        return "Report Data";
    }
}
public class ReportPrinter
{
    public void PrintReport(string reportData)
    {
        // Code to print the report
        Console.WriteLine("Printing Report: " + reportData);
    }
}
