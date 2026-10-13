using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{

    // sealed class mean that this class cannot be inherited by any other class.to prevent any edit in class
    sealed class SchoolReport
    {
        public string ReportTitle { get; set; }

        public string DisplayReportTitle()
        {
            return $"Report Title: {ReportTitle}";
        }

        public SchoolReport(string reportTitle)
        {
            ReportTitle = reportTitle;
        }

    }
}
