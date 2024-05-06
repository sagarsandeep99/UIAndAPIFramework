using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports.Reporter.Config;



namespace SpecFlowProject_Wipfli.Utilities;

public class ExtentReport
{
    public static ExtentReports _extentReports;
    public static ExtentTest _feature;
    public static ExtentTest _scenario;
    public static ScenarioContext _scenarioContext;

    public static string dir = AppDomain.CurrentDomain.BaseDirectory;
    //public static string testResultPath = GetFilePath.FilePath(@"TestReports\");
    public static string testResultPath = @"D:\Old Laptop\Wipfli Projects\QA\Wipfli_AutomationFramework\wipfli-test-automation-specflow\SpecFlowProject_Wipfli\TestReports\TestReport.html";
    //public static string testResultPath = GetFilePath.FilePath(@"wipfli-test-automation-specflow\SpecFlowProject_Wipfli\TestReports\");


    public static void ExtentReportSetup()
    {
        var htmlReporter = new ExtentSparkReporter(testResultPath);
        //htmlReporter.Config.ReportName = "SpecFlow Automation Status Report";
        //htmlReporter.Config.DocumentTitle = "Gmail Automation Status Report";
        //htmlReporter.Config.Theme = Theme.Dark;
        //htmlReporter.Start();

        _extentReports = new ExtentReports();
        _extentReports.AttachReporter(htmlReporter);
        //_extentReports.AddSystemInfo("Application", "Gmail");
        //_extentReports.AddSystemInfo("Browser", "Chrome");
        //_extentReports.AddSystemInfo("OS", "Windows");
    }

    public static void ExtentReportTearDown()
    {
        _extentReports.Flush();
    }
}