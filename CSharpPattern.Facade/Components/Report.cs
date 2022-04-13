using System;

namespace CSharpPattern.Facade.Components
{
    public class Report
    {
        public string GetExternalReport(string identification, string sex) { return string.IsNullOrEmpty(identification) ? string.Empty : "OK"; }

        public bool isRejected(string report) { return string.IsNullOrEmpty(report); }

        public void ReportRejected() { Console.WriteLine("External Report rejected."); }
    }
}
